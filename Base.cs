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
using System.Speech.Synthesis;
using NAudio.Wave.SampleProviders;
using Microsoft.VisualBasic;
using NWaves.Audio.Interfaces;
using NWaves.Audio.Mci;

namespace arabic_nlp
{
    public partial class Base : MetroForm
    {
        WaveIn wave;
        WaveFileWriter writer;
        string outputFileName;
        private List<WaveFeature> waves = new List<WaveFeature>();
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private List<Sound> sounds = new List<Sound>();
        private const string wavesPath = "waves.json";

        public Base()
        {
            InitializeComponent();
            LoadDevices();
            FillAudioGridView();
            ComboBoxAudioOptions();
            ComboBoxOutputOptions();
            ComboBoxCharOptions();
            ComboBoxMovmentsOptions();
        }

        private void ComboBoxCharOptions()
        {
            charComboBox.DataSource = Enum.GetValues(typeof(Chars)).Cast<Chars>().Select(e => new
            {
                Key = e.ToString(),
                Value = (int)e
            }).ToList();
            charComboBox.ValueMember = "Value";
            charComboBox.DisplayMember = "Key";
        }

        private void ComboBoxMovmentsOptions()
        {
            movementComboBox.DataSource = Enum.GetValues(typeof(SoundType)).Cast<SoundType>().Select(e => new
            {
                Key = e.ToString(),
                Value = (int)e
            }).ToList();
            movementComboBox.ValueMember = "Value";
            movementComboBox.DisplayMember = "Key";
        }

        private void ComboBoxOutputOptions()
        {
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                OutputCombo.Items.Add(voice.VoiceInfo.Name);
            }
            OutputCombo.SelectedIndex = 0;
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
                WaveResultText.Text = "الملف يحتوي على كلمة " + orderedTemp.First().Item2.ToString();
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

        private void ToSpeechButton_Click(object sender, EventArgs e)
        {
            synthesizer.Dispose();
            synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            //synthesizer.Rate = -2;     // -10...10

            synthesizer.SelectVoice(OutputCombo.Text);
            synthesizer.SpeakAsync(ToSpeechText.Text);
            //synthesizer.SpeakAsync(ToSpeechText.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ToSpeechText.Clear();
        }

        private void clearReadTextButton_Click(object sender, EventArgs e)
        {
            ReadText.Clear();
        }

        private void ReadTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<ISampleProvider> samples = new List<ISampleProvider>();
                AudioFileReader audioFileReader;
                var words = ReadText.Text.Split(' ', '\t', '\n', ';', ',', '.', '،').Where(t => t != "").ToList();
                char[] voicemovments = { 'و', 'ي' };
                char[] movments = { 'َ', 'ُ', 'ِ', 'ْ' };
                bool flag = words.Count > 0;
                string sound = null;
                foreach (var word in words)
                {
                    for (int i = 0; i < word.Length;)
                    {
                        if (i + 1 < word.Length && Array.IndexOf(movments, word[i + 1]) > -1)
                        {
                            sound = word[i].ToString() + word[i + 1].ToString();
                            i++;
                        }
                        else if (i + 1 < word.Length && Array.IndexOf(voicemovments, word[i + 1]) > -1)
                        {
                            char direction;
                            switch (word[i + 1])
                            {
                                case 'ي':
                                    direction = 'ِ';
                                    break;
                                case 'و':
                                    direction = 'ُ';
                                    break;
                                default:
                                    direction = 'َ';
                                    break;
                            }

                            sound = word[i].ToString() + direction;
                            i++;
                        }
                        else
                        {
                            sound = word[i].ToString() + "َ";
                        }
                        try
                        {
                            audioFileReader = new AudioFileReader("D:\\char_samples\\" + sound + ".m4a");
                            TimeSpan timeSpan = TimeSpan.FromMilliseconds(375);
                            TimeSpan skiptime = TimeSpan.FromMilliseconds(110);
                            samples.Add(audioFileReader.Take(timeSpan).Skip(skiptime));
                        }
                        catch
                        {
                            flag = false;
                        }
                        i++;
                    }
                }
                if (flag)
                {
                    var mixer = new ConcatenatingSampleProvider(samples);
                    WaveFileWriter.CreateWaveFile16("d:\\mixed.wav", mixer);

                    IAudioPlayer player = new MciAudioPlayer();

                    player.PlayAsync("d:\\mixed.wav");
                }
                else
                {
                    MessageBox.Show("لم يتم التعرف على أحد الكلمات");
                }
            }
            catch (Exception)
            {

            }
        }

        private void charMovmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                char movment;
                switch (movementComboBox.Text)
                {
                    case "ألف":
                        movment = 'ا';
                        break;
                    case "واو":
                        movment = 'و';
                        break;
                    case "ياء":
                        movment = 'ي';
                        break;
                    case "فتحة":
                        movment = 'َ';
                        break;
                    case "ضمة":
                        movment = 'ُ';
                        break;
                    case "كسرة":
                        movment = 'ِ';
                        break;
                    case "سكون":
                        movment = 'ْ';
                        break;
                    default:
                        movment = 'َ';
                        break;
                }
                if (charComboBox.Text != "" && movementComboBox.Text != "" && open_input_dialog.ShowDialog() == DialogResult.OK)
                {
                    Directory.Move(open_input_dialog.FileName, "D:\\char_samples\\" + charComboBox.Text + movment + ".m4a");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("الرجاء اختيار ملف من القرص D");
            }
        }
    }
}
