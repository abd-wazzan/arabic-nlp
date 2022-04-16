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

namespace arabic_nlp
{
    public partial class Base : MetroForm
    {

        public Base()
        {
            InitializeComponent();
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
    }
}
