
namespace arabic_nlp
{
    partial class Base
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.output_grid = new System.Windows.Forms.DataGridView();
            this.input_txt = new MetroFramework.Controls.MetroTextBox();
            this.run_btn = new MetroFramework.Controls.MetroButton();
            this.clear_btn = new MetroFramework.Controls.MetroButton();
            this.choose_file_btn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.open_input_dialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RecordButton = new MetroFramework.Controls.MetroButton();
            this.RecordingDeviceComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.RecordFileText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.AnalysisRecordFileText = new MetroFramework.Controls.MetroTextBox();
            this.AnalysSoundButton = new MetroFramework.Controls.MetroButton();
            this.ClearSoundButton = new MetroFramework.Controls.MetroButton();
            this.ChooseSoundButton = new MetroFramework.Controls.MetroButton();
            this.WaveGridView = new System.Windows.Forms.DataGridView();
            this.WaveTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.AddToWavesButton = new MetroFramework.Controls.MetroButton();
            this.WaveResultText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output_grid)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.RightToLeftLayout = true;
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1240, 666);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.output_grid);
            this.metroTabPage1.Controls.Add(this.input_txt);
            this.metroTabPage1.Controls.Add(this.run_btn);
            this.metroTabPage1.Controls.Add(this.clear_btn);
            this.metroTabPage1.Controls.Add(this.choose_file_btn);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 22;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1232, 618);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "المحلل الصرفي";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 11;
            // 
            // output_grid
            // 
            this.output_grid.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.output_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_grid.Location = new System.Drawing.Point(488, 22);
            this.output_grid.Name = "output_grid";
            this.output_grid.RowHeadersWidth = 51;
            this.output_grid.RowTemplate.Height = 26;
            this.output_grid.Size = new System.Drawing.Size(714, 578);
            this.output_grid.TabIndex = 8;
            // 
            // input_txt
            // 
            // 
            // 
            // 
            this.input_txt.CustomButton.Image = null;
            this.input_txt.CustomButton.Location = new System.Drawing.Point(-43, 2);
            this.input_txt.CustomButton.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.input_txt.CustomButton.Name = "";
            this.input_txt.CustomButton.Size = new System.Drawing.Size(495, 566);
            this.input_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.input_txt.CustomButton.TabIndex = 1;
            this.input_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.input_txt.CustomButton.UseSelectable = true;
            this.input_txt.CustomButton.Visible = false;
            this.input_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.input_txt.Lines = new string[0];
            this.input_txt.Location = new System.Drawing.Point(18, 22);
            this.input_txt.MaxLength = 32767;
            this.input_txt.Multiline = true;
            this.input_txt.Name = "input_txt";
            this.input_txt.PasswordChar = '\0';
            this.input_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.input_txt.SelectedText = "";
            this.input_txt.SelectionLength = 0;
            this.input_txt.SelectionStart = 0;
            this.input_txt.ShortcutsEnabled = false;
            this.input_txt.Size = new System.Drawing.Size(455, 500);
            this.input_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.input_txt.TabIndex = 5;
            this.input_txt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.input_txt.UseSelectable = true;
            this.input_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.input_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // run_btn
            // 
            this.run_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.run_btn.Highlight = true;
            this.run_btn.Location = new System.Drawing.Point(353, 540);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(120, 60);
            this.run_btn.Style = MetroFramework.MetroColorStyle.Green;
            this.run_btn.TabIndex = 4;
            this.run_btn.Text = "ابدأ";
            this.run_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.run_btn.UseSelectable = true;
            this.run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clear_btn.Highlight = true;
            this.clear_btn.Location = new System.Drawing.Point(185, 540);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(120, 60);
            this.clear_btn.Style = MetroFramework.MetroColorStyle.Red;
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "تهيئة";
            this.clear_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.clear_btn.UseSelectable = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // choose_file_btn
            // 
            this.choose_file_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.choose_file_btn.Highlight = true;
            this.choose_file_btn.Location = new System.Drawing.Point(18, 540);
            this.choose_file_btn.Name = "choose_file_btn";
            this.choose_file_btn.Size = new System.Drawing.Size(120, 60);
            this.choose_file_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.choose_file_btn.TabIndex = 2;
            this.choose_file_btn.Text = "اختر ملف";
            this.choose_file_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.choose_file_btn.UseSelectable = true;
            this.choose_file_btn.Click += new System.EventHandler(this.choose_file_btn_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.WaveGridView);
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 11;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1232, 618);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "المحلل الصوتي";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // open_input_dialog
            // 
            this.open_input_dialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.RecordFileText);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.RecordingDeviceComboBox);
            this.groupBox1.Controls.Add(this.RecordButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(32, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تسجيل الصوت";
            // 
            // RecordButton
            // 
            this.RecordButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.RecordButton.Highlight = true;
            this.RecordButton.Location = new System.Drawing.Point(157, 163);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(120, 60);
            this.RecordButton.Style = MetroFramework.MetroColorStyle.Green;
            this.RecordButton.TabIndex = 6;
            this.RecordButton.Text = "تسجيل";
            this.RecordButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RecordButton.UseSelectable = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // RecordingDeviceComboBox
            // 
            this.RecordingDeviceComboBox.FormattingEnabled = true;
            this.RecordingDeviceComboBox.ItemHeight = 24;
            this.RecordingDeviceComboBox.Location = new System.Drawing.Point(58, 56);
            this.RecordingDeviceComboBox.Name = "RecordingDeviceComboBox";
            this.RecordingDeviceComboBox.Size = new System.Drawing.Size(270, 30);
            this.RecordingDeviceComboBox.TabIndex = 7;
            this.RecordingDeviceComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RecordingDeviceComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(353, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "جهاز التسجيل";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RecordFileText
            // 
            // 
            // 
            // 
            this.RecordFileText.CustomButton.Image = null;
            this.RecordFileText.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.RecordFileText.CustomButton.Name = "";
            this.RecordFileText.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.RecordFileText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RecordFileText.CustomButton.TabIndex = 1;
            this.RecordFileText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RecordFileText.CustomButton.UseSelectable = true;
            this.RecordFileText.CustomButton.Visible = false;
            this.RecordFileText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.RecordFileText.Lines = new string[0];
            this.RecordFileText.Location = new System.Drawing.Point(58, 116);
            this.RecordFileText.MaxLength = 32767;
            this.RecordFileText.Name = "RecordFileText";
            this.RecordFileText.PasswordChar = '\0';
            this.RecordFileText.ReadOnly = true;
            this.RecordFileText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecordFileText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RecordFileText.SelectedText = "";
            this.RecordFileText.SelectionLength = 0;
            this.RecordFileText.SelectionStart = 0;
            this.RecordFileText.ShortcutsEnabled = true;
            this.RecordFileText.Size = new System.Drawing.Size(270, 30);
            this.RecordFileText.TabIndex = 9;
            this.RecordFileText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RecordFileText.UseSelectable = true;
            this.RecordFileText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RecordFileText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(353, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 20);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "مسار الملف";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.WaveResultText);
            this.groupBox2.Controls.Add(this.AddToWavesButton);
            this.groupBox2.Controls.Add(this.WaveTypeComboBox);
            this.groupBox2.Controls.Add(this.ChooseSoundButton);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.AnalysisRecordFileText);
            this.groupBox2.Controls.Add(this.AnalysSoundButton);
            this.groupBox2.Controls.Add(this.ClearSoundButton);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(32, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 301);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحليل الصوت";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(353, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 20);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "مسار الملف";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AnalysisRecordFileText
            // 
            // 
            // 
            // 
            this.AnalysisRecordFileText.CustomButton.Image = null;
            this.AnalysisRecordFileText.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.AnalysisRecordFileText.CustomButton.Name = "";
            this.AnalysisRecordFileText.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.AnalysisRecordFileText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AnalysisRecordFileText.CustomButton.TabIndex = 1;
            this.AnalysisRecordFileText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AnalysisRecordFileText.CustomButton.UseSelectable = true;
            this.AnalysisRecordFileText.CustomButton.Visible = false;
            this.AnalysisRecordFileText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.AnalysisRecordFileText.Lines = new string[0];
            this.AnalysisRecordFileText.Location = new System.Drawing.Point(58, 63);
            this.AnalysisRecordFileText.MaxLength = 32767;
            this.AnalysisRecordFileText.Name = "AnalysisRecordFileText";
            this.AnalysisRecordFileText.PasswordChar = '\0';
            this.AnalysisRecordFileText.ReadOnly = true;
            this.AnalysisRecordFileText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnalysisRecordFileText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AnalysisRecordFileText.SelectedText = "";
            this.AnalysisRecordFileText.SelectionLength = 0;
            this.AnalysisRecordFileText.SelectionStart = 0;
            this.AnalysisRecordFileText.ShortcutsEnabled = true;
            this.AnalysisRecordFileText.Size = new System.Drawing.Size(270, 30);
            this.AnalysisRecordFileText.TabIndex = 9;
            this.AnalysisRecordFileText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AnalysisRecordFileText.UseSelectable = true;
            this.AnalysisRecordFileText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AnalysisRecordFileText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AnalysSoundButton
            // 
            this.AnalysSoundButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.AnalysSoundButton.Highlight = true;
            this.AnalysSoundButton.Location = new System.Drawing.Point(183, 173);
            this.AnalysSoundButton.Name = "AnalysSoundButton";
            this.AnalysSoundButton.Size = new System.Drawing.Size(120, 44);
            this.AnalysSoundButton.Style = MetroFramework.MetroColorStyle.Green;
            this.AnalysSoundButton.TabIndex = 6;
            this.AnalysSoundButton.Text = "تحليل";
            this.AnalysSoundButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AnalysSoundButton.UseSelectable = true;
            this.AnalysSoundButton.Click += new System.EventHandler(this.AnalysSoundButton_Click);
            // 
            // ClearSoundButton
            // 
            this.ClearSoundButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ClearSoundButton.Highlight = true;
            this.ClearSoundButton.Location = new System.Drawing.Point(57, 173);
            this.ClearSoundButton.Name = "ClearSoundButton";
            this.ClearSoundButton.Size = new System.Drawing.Size(120, 44);
            this.ClearSoundButton.Style = MetroFramework.MetroColorStyle.Red;
            this.ClearSoundButton.TabIndex = 5;
            this.ClearSoundButton.Text = "تهيئة";
            this.ClearSoundButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ClearSoundButton.UseSelectable = true;
            this.ClearSoundButton.Click += new System.EventHandler(this.ClearSoundButton_Click);
            // 
            // ChooseSoundButton
            // 
            this.ChooseSoundButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ChooseSoundButton.Highlight = true;
            this.ChooseSoundButton.Location = new System.Drawing.Point(244, 99);
            this.ChooseSoundButton.Name = "ChooseSoundButton";
            this.ChooseSoundButton.Size = new System.Drawing.Size(84, 35);
            this.ChooseSoundButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChooseSoundButton.TabIndex = 11;
            this.ChooseSoundButton.Text = "اختر ملف";
            this.ChooseSoundButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChooseSoundButton.UseSelectable = true;
            this.ChooseSoundButton.Click += new System.EventHandler(this.ChooseSoundButton_Click);
            // 
            // WaveGridView
            // 
            this.WaveGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WaveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaveGridView.Location = new System.Drawing.Point(541, 27);
            this.WaveGridView.Name = "WaveGridView";
            this.WaveGridView.RowHeadersWidth = 51;
            this.WaveGridView.RowTemplate.Height = 26;
            this.WaveGridView.Size = new System.Drawing.Size(637, 579);
            this.WaveGridView.TabIndex = 12;
            // 
            // WaveTypeComboBox
            // 
            this.WaveTypeComboBox.FormattingEnabled = true;
            this.WaveTypeComboBox.ItemHeight = 24;
            this.WaveTypeComboBox.Location = new System.Drawing.Point(58, 101);
            this.WaveTypeComboBox.Name = "WaveTypeComboBox";
            this.WaveTypeComboBox.Size = new System.Drawing.Size(107, 30);
            this.WaveTypeComboBox.TabIndex = 11;
            this.WaveTypeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WaveTypeComboBox.UseSelectable = true;
            // 
            // AddToWavesButton
            // 
            this.AddToWavesButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.AddToWavesButton.Highlight = true;
            this.AddToWavesButton.Location = new System.Drawing.Point(309, 173);
            this.AddToWavesButton.Name = "AddToWavesButton";
            this.AddToWavesButton.Size = new System.Drawing.Size(120, 44);
            this.AddToWavesButton.TabIndex = 12;
            this.AddToWavesButton.Text = "إضافة";
            this.AddToWavesButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddToWavesButton.UseSelectable = true;
            this.AddToWavesButton.Click += new System.EventHandler(this.AddToWavesButton_Click);
            // 
            // WaveResultText
            // 
            // 
            // 
            // 
            this.WaveResultText.CustomButton.Image = null;
            this.WaveResultText.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.WaveResultText.CustomButton.Name = "";
            this.WaveResultText.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.WaveResultText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WaveResultText.CustomButton.TabIndex = 1;
            this.WaveResultText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WaveResultText.CustomButton.UseSelectable = true;
            this.WaveResultText.CustomButton.Visible = false;
            this.WaveResultText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.WaveResultText.Lines = new string[0];
            this.WaveResultText.Location = new System.Drawing.Point(57, 235);
            this.WaveResultText.MaxLength = 32767;
            this.WaveResultText.Name = "WaveResultText";
            this.WaveResultText.PasswordChar = '\0';
            this.WaveResultText.ReadOnly = true;
            this.WaveResultText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WaveResultText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WaveResultText.SelectedText = "";
            this.WaveResultText.SelectionLength = 0;
            this.WaveResultText.SelectionStart = 0;
            this.WaveResultText.ShortcutsEnabled = true;
            this.WaveResultText.Size = new System.Drawing.Size(270, 30);
            this.WaveResultText.TabIndex = 13;
            this.WaveResultText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WaveResultText.UseSelectable = true;
            this.WaveResultText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WaveResultText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(353, 239);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 20);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "النتيجة";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 744);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 7F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Base";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تحليل اللغة العربية";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.output_grid)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaveGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton run_btn;
        private MetroFramework.Controls.MetroButton clear_btn;
        private MetroFramework.Controls.MetroButton choose_file_btn;
        private MetroFramework.Controls.MetroTextBox input_txt;
        private System.Windows.Forms.OpenFileDialog open_input_dialog;
        private System.Windows.Forms.DataGridView output_grid;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox RecordingDeviceComboBox;
        private MetroFramework.Controls.MetroButton RecordButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox RecordFileText;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton ChooseSoundButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox AnalysisRecordFileText;
        private MetroFramework.Controls.MetroButton AnalysSoundButton;
        private MetroFramework.Controls.MetroButton ClearSoundButton;
        private System.Windows.Forms.DataGridView WaveGridView;
        private MetroFramework.Controls.MetroComboBox WaveTypeComboBox;
        private MetroFramework.Controls.MetroButton AddToWavesButton;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox WaveResultText;
    }
}

