using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using NAudio.Wave;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Collections;
using Microsoft.VisualBasic;
using NWaves.FeatureExtractors.Options;
using NWaves.Signals;
using NWaves.Audio;
using NWaves.Operations;
using NWaves.Windows;
using NWaves.FeatureExtractors;
using NWaves.FeatureExtractors.Serializers;

namespace arabic_nlp
{
    public partial class Base : MetroForm
    {
        WaveIn wave;
        WaveFileWriter writer;
        string outputFileName;
        private List<WaveFeature> waves = new List<WaveFeature>();
        private const string wavesPath = "waves.json";

        public Base()
        {
            InitializeComponent();
            LoadDevices();
            FillAudioGridView();
            ComboBoxAudioOptions();
        }

        private dynamic GetComboBoxWaveList()
        {
            return Enum.GetValues(typeof(WaveTypes)).Cast<WaveTypes>().Select(e => new
            {
                Key = e.ToString(),
                Value = (int)e
            }).ToList();
        }

        private void LoadDevices()
        {
            for (int deviceId = 0; deviceId < WaveIn.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveIn.GetCapabilities(deviceId);
                RecordingDeviceComboBox.Items.Add(deviceInfo.ProductName);
            }
            RecordingDeviceComboBox.SelectedIndex = 0;
        }

        private void ComboBoxAudioOptions()
        {
            WaveTypeComboBox.DataSource = GetComboBoxWaveList();
            WaveTypeComboBox.ValueMember = "Value";
            WaveTypeComboBox.DisplayMember = "Key";
        }

        private void FillAudioGridView()
        {
            using (StreamReader r = new StreamReader(wavesPath))
            {
                string json = r.ReadToEnd();
                waves = JsonConvert.DeserializeObject<List<WaveFeature>>(json);
                TableFiller.SetControl(WaveGridView, waves);
            }
        }

        private void choose_file_btn_Click(object sender, EventArgs e)
        {
            if (open_input_dialog.ShowDialog() == DialogResult.OK)
            { 
                using (StreamReader read = new StreamReader(open_input_dialog.FileName))
                {
                    while (true)
                    {
                        string line = read.ReadLine();
                        if (line == null)
                            break;
                        input_txt.Text += line + "\n";
                    }
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            input_txt.Clear();
            output_grid.Rows.Clear();
            output_grid.Refresh();
        }

        private void Run_btn_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',', '.', ':', '\t', '\n'};
            List<string> allLines = new List<string>();
            List<Sentence> sentences = new List<Sentence>();
            allLines = (from item in input_txt.Text.Split(delimiterChars) select item.Trim()).ToList();
            foreach(string line in allLines)
            {
                sentences.Add(new Sentence(line));
            }
            TableFiller.SetControl(output_grid, sentences);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            if(RecordButton.Style == MetroFramework.MetroColorStyle.Green)
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "Wave files | *.wav";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                outputFileName = dialog.FileName;
                RecordFileText.Text = outputFileName;
                AnalysisRecordFileText.Text = outputFileName;

                RecordButton.Style = MetroFramework.MetroColorStyle.Red;
                RecordButton.Text = "ايقاف";

                wave = new WaveIn();
                wave.WaveFormat = new NAudio.Wave.WaveFormat(44100, 1);
                wave.DeviceNumber = RecordingDeviceComboBox.SelectedIndex;
                wave.DataAvailable += Wave_DataAvailable;
                wave.RecordingStopped += Wave_RecordingStopped;
                writer = new WaveFileWriter(outputFileName, wave.WaveFormat);
                wave.StartRecording();
            }
            else
            {
                RecordButton.Style = MetroFramework.MetroColorStyle.Green;
                RecordButton.Text = "تسجيل";
                wave.StopRecording();

                if (outputFileName == null)
                    return;

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = Path.GetDirectoryName(outputFileName),
                    UseShellExecute = true
                };

                Process.Start(processStartInfo);
            }
        }

        private void Wave_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer.Dispose();
        }

        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void StopRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void ChooseSoundButton_Click(object sender, EventArgs e)
        {
            if (open_input_dialog.ShowDialog() == DialogResult.OK)
            {
                AnalysisRecordFileText.Text = open_input_dialog.FileName;
            }
        }

        private void ClearSoundButton_Click(object sender, EventArgs e)
        {
            AnalysisRecordFileText.Clear();
            WaveResultText.Clear();
        }

        private void AnalysSoundButton_Click(object sender, EventArgs e)
        {
            using (var stream = new FileStream(AnalysisRecordFileText.Text, FileMode.Open))
            {
                var waveFile = new WaveFile(stream);
                var signalLeft = waveFile[Channels.Left];
                var ZCR = signalLeft.ZeroCrossingRate();
                var Energy = signalLeft.Energy();
                var RMS = signalLeft.Rms();
                List<(double, WaveTypes)> temp = new List<(double, WaveTypes)>();
                foreach (var wave in waves)
                {
                    double diff = 0;
                    diff += Math.Abs(wave.ZCR - ZCR);
                    diff += Math.Abs(wave.Energy - Energy);
                    diff += Math.Abs(wave.RMS - RMS);
                    temp.Add((diff, wave.Type));
                }
                var orderedTemp = temp.OrderBy(a => a.Item1);
                WaveResultText.Text = "التسجيل يحوي كلمة " + orderedTemp.First().Item2.ToString();
            }
        }

        private void AddToWavesButton_Click(object sender, EventArgs e)
        {
            var id = waves.Any() ? waves.Max(a => a.Id) + 1 : 1;
            using (var stream = new FileStream(AnalysisRecordFileText.Text, FileMode.Open))
            {
                var waveFile = new WaveFile(stream);
                var signalLeft = waveFile[Channels.Left];
                var rmsNorm = Operation.NormalizeRms(signalLeft, -6/*dBFS*/);
                var ZCR = signalLeft.ZeroCrossingRate();
                var Energy = signalLeft.Energy();
                var RMS = signalLeft.Rms();
                waves.Add(new WaveFeature
                {
                    Id = id,
                    Energy = Energy,
                    Type = (WaveTypes)WaveTypeComboBox.SelectedIndex,
                    RMS = RMS,
                    ZCR = ZCR,
                });
                TableFiller.SetControl(WaveGridView, waves);
            }
            using (StreamWriter writer = new StreamWriter(wavesPath))
            {
                var temp = Newtonsoft.Json.JsonConvert.SerializeObject(waves);
                writer.Write(temp);
            }
        }
    }
}
