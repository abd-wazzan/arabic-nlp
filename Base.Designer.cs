﻿
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
            this.input_txt = new MetroFramework.Controls.MetroTextBox();
            this.run_btn = new MetroFramework.Controls.MetroButton();
            this.clear_btn = new MetroFramework.Controls.MetroButton();
            this.choose_file_btn = new MetroFramework.Controls.MetroButton();
            this.open_input_dialog = new System.Windows.Forms.OpenFileDialog();
            this.output_grid = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.RightToLeftLayout = true;
            this.metroTabControl1.SelectedIndex = 0;
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
            this.metroTabPage1.HorizontalScrollbarSize = 15;
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
            // input_txt
            // 
            // 
            // 
            // 
            this.input_txt.CustomButton.Image = null;
            this.input_txt.CustomButton.Location = new System.Drawing.Point(-43, 2);
            this.input_txt.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input_txt.CustomButton.Name = "";
            this.input_txt.CustomButton.Size = new System.Drawing.Size(495, 495);
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
            // open_input_dialog
            // 
            this.open_input_dialog.FileName = "openFileDialog1";
            // 
            // output_grid
            // 
            this.output_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_grid.Location = new System.Drawing.Point(488, 22);
            this.output_grid.Name = "output_grid";
            this.output_grid.RowHeadersWidth = 51;
            this.output_grid.RowTemplate.Height = 26;
            this.output_grid.Size = new System.Drawing.Size(714, 578);
            this.output_grid.TabIndex = 8;
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
    }
}

