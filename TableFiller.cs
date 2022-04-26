using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace arabic_nlp
{
    static class TableFiller
    {
        public static List<string> columnsNames = new List<string>()
            {
                "الكلمة",
                "السابقة",
                "التجريد",
                "اللاحقة",
                "الوزن",
                "الجذر",
                "النوع"
            };

        public static List<string> waveColumns = new List<string>()
            {
                "المعرف",
                "النوع",
                "RMS",
                "ZRC",
                "Energy"
            };

        public static void SetControl(DataGridView gridView, List<Sentence> sentences)
        {
            gridView.Rows.Clear();
            gridView.Refresh();

            gridView.ColumnCount = columnsNames.Count;

            for (int i = 0; i < columnsNames.Count; i++)
            {
                gridView.Columns[i].Name = columnsNames[i];
            }
                
            foreach (var sentence in sentences)
            {
                foreach (var word in sentence.words)
                {
                    gridView.Rows.Add(new object[] { word.name, word.prefix, word.abstruct, word.suffix, word.weight, word.root, word.meaning});
                }
                gridView.Rows.Add(new object[] { "", "", "", "", "", "", "" });
            }

            if (gridView.Width > 100 * columnsNames.Count)
            {
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            else
            {
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            ///////////////
            gridView.AllowUserToAddRows = false;
            gridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            gridView.RightToLeft = RightToLeft.Yes;
            gridView.MultiSelect = false;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.ReadOnly = true;
            gridView.BorderStyle = BorderStyle.None;
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            gridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 175, 220);
            gridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridView.BackgroundColor = Color.FromArgb(17, 17, 17);
            gridView.EnableHeadersVisualStyles = false;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200);
            gridView.GridColor = Color.FromArgb(70, 70, 70);
            gridView.DefaultCellStyle.Font = new Font("Tahoma", 10.3F, FontStyle.Regular);
            gridView.RowHeadersVisible = false;
            gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.AllowUserToResizeRows = false;
            gridView.DefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200);
            gridView.DefaultCellStyle.BackColor = Color.FromArgb(70, 70, 70);
            gridView.BorderStyle = BorderStyle.Fixed3D;
            gridView.RowTemplate.Height = 30;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10.3F, FontStyle.Bold);
        }

        public static void SetControl(DataGridView gridView, List<WaveFeature> waves)
        {
            gridView.Rows.Clear();
            gridView.Refresh();

            gridView.ColumnCount = waveColumns.Count;

            for (int i = 0; i < waveColumns.Count; i++)
            {
                gridView.Columns[i].Name = waveColumns[i];
            }

            foreach (var wave in waves)
            {
                gridView.Rows.Add(new object[] { wave.Id, wave.Type, Math.Round(wave.RMS, 10).ToString(), Math.Round(wave.ZCR, 10).ToString(), Math.Round(wave.Energy, 10).ToString() });
            }

            if (gridView.Width > 100 * waveColumns.Count)
            {
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            else
            {
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            ///////////////
            gridView.AllowUserToAddRows = false;
            gridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            gridView.RightToLeft = RightToLeft.Yes;
            gridView.MultiSelect = false;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.ReadOnly = true;
            gridView.BorderStyle = BorderStyle.None;
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            gridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 175, 220);
            gridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridView.BackgroundColor = Color.FromArgb(17, 17, 17);
            gridView.EnableHeadersVisualStyles = false;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200);
            gridView.GridColor = Color.FromArgb(70, 70, 70);
            gridView.DefaultCellStyle.Font = new Font("Tahoma", 10.3F, FontStyle.Regular);
            gridView.RowHeadersVisible = false;
            gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.AllowUserToResizeRows = false;
            gridView.DefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200);
            gridView.DefaultCellStyle.BackColor = Color.FromArgb(70, 70, 70);
            gridView.BorderStyle = BorderStyle.Fixed3D;
            gridView.RowTemplate.Height = 30;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10.3F, FontStyle.Bold);
        }

        public static void SetControl(ListView listView, List<Sentence> sentences)
        {

            listView.Columns.Clear();
            listView.Items.Clear();
            listView.RightToLeft = RightToLeft.Yes;
            listView.RightToLeftLayout = true;
            listView.FullRowSelect = true;
            listView.MultiSelect = false;
            listView.View = View.Details;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            for (int i = 0; i < columnsNames.Count; i++)
            {
                listView.Columns.Add(columnsNames[i]);
                if (listView.Width > 100 * columnsNames.Count)
                {
                    listView.Columns[i].Width = ((listView.Width) / columnsNames.Count);
                }
                else
                {
                    listView.Columns[i].Width = 100;
                }
                listView.Columns[i].TextAlign = HorizontalAlignment.Center;
            }
            listView.Font = new Font("Tahoma", 10.3F);

            for (int i = 0; i < sentences.Count; i++)
            {
                string[] s = new string[columnsNames.Count];

                for (int j = 0; j < sentences[i].words.Count; j++)
                {
                    s[0] = sentences[i].words[j].name;
                    s[1] = sentences[i].words[j].prefix;
                    s[2] = sentences[i].words[j].abstruct;
                    s[3] = sentences[i].words[j].suffix;
                    s[4] = sentences[i].words[j].weight;
                    s[5] = sentences[i].words[j].root;
                    s[6] = sentences[i].words[j].meaning;
                }

                ListViewItem lv = new ListViewItem(s);
                listView.Items.Add(lv);


                if (i % 2 == 0)
                { listView.Items[i].BackColor = Color.DarkSlateGray; }
            }

        }
    }
}
