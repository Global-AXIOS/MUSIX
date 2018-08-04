namespace Musix_v5
{
    partial class Settings
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.macTrackBar3 = new XComponent.SliderBar.MACTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.macTrackBar2 = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.formSkin2 = new FlatUI.FormSkin();
            this.button1 = new System.Windows.Forms.Button();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flatButton6 = new FlatUI.FlatButton();
            this.flatButton5 = new FlatUI.FlatButton();
            this.flatButton4 = new FlatUI.FlatButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.flatButton3 = new FlatUI.FlatButton();
            this.macTrackBar1 = new FlatUI.FlatToggle();
            this.formSkin2.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(9, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(423, 414);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(397, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(22, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "L";
            // 
            // macTrackBar3
            // 
            this.macTrackBar3.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.macTrackBar3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar3.IndentHeight = 6;
            this.macTrackBar3.LargeChange = 1;
            this.macTrackBar3.Location = new System.Drawing.Point(44, 152);
            this.macTrackBar3.Maximum = 100;
            this.macTrackBar3.Minimum = -100;
            this.macTrackBar3.Name = "macTrackBar3";
            this.macTrackBar3.Size = new System.Drawing.Size(347, 22);
            this.macTrackBar3.TabIndex = 5;
            this.macTrackBar3.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar3.TickColor = System.Drawing.Color.Black;
            this.macTrackBar3.TickHeight = 4;
            this.macTrackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar3.TrackerColor = System.Drawing.Color.DeepSkyBlue;
            this.macTrackBar3.TrackerSize = new System.Drawing.Size(10, 10);
            this.macTrackBar3.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.macTrackBar3.TrackLineHeight = 10;
            this.macTrackBar3.Value = 0;
            this.macTrackBar3.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Audio Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(173, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "100%";
            // 
            // macTrackBar2
            // 
            this.macTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.macTrackBar2.Enabled = false;
            this.macTrackBar2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar2.IndentHeight = 6;
            this.macTrackBar2.LargeChange = 1;
            this.macTrackBar2.Location = new System.Drawing.Point(44, 45);
            this.macTrackBar2.Maximum = 100;
            this.macTrackBar2.Minimum = 0;
            this.macTrackBar2.Name = "macTrackBar2";
            this.macTrackBar2.Size = new System.Drawing.Size(347, 22);
            this.macTrackBar2.TabIndex = 2;
            this.macTrackBar2.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar2.TickColor = System.Drawing.Color.Black;
            this.macTrackBar2.TickHeight = 4;
            this.macTrackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar2.TrackerColor = System.Drawing.Color.DeepSkyBlue;
            this.macTrackBar2.TrackerSize = new System.Drawing.Size(10, 10);
            this.macTrackBar2.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.macTrackBar2.TrackLineHeight = 10;
            this.macTrackBar2.Value = 100;
            this.macTrackBar2.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volume Limit";
            // 
            // formSkin2
            // 
            this.formSkin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.formSkin2.BaseColor = System.Drawing.Color.White;
            this.formSkin2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.formSkin2.Controls.Add(this.button1);
            this.formSkin2.Controls.Add(this.flatTabControl1);
            this.formSkin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin2.FlatColor = System.Drawing.Color.DodgerBlue;
            this.formSkin2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin2.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.formSkin2.HeaderMaximize = false;
            this.formSkin2.Location = new System.Drawing.Point(0, 0);
            this.formSkin2.Name = "formSkin2";
            this.formSkin2.Size = new System.Drawing.Size(447, 574);
            this.formSkin2.TabIndex = 2;
            this.formSkin2.Text = "Settings";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(411, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.DodgerBlue;
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.flatTabControl1.Controls.Add(this.tabPage4);
            this.flatTabControl1.Controls.Add(this.tabPage5);
            this.flatTabControl1.Controls.Add(this.tabPage6);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(90, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(-1, 51);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(448, 523);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage4.Controls.Add(this.flatButton6);
            this.tabPage4.Controls.Add(this.flatButton5);
            this.tabPage4.Controls.Add(this.flatButton4);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(440, 475);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Musix sys";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // flatButton6
            // 
            this.flatButton6.BackColor = System.Drawing.Color.Transparent;
            this.flatButton6.BaseColor = System.Drawing.Color.DodgerBlue;
            this.flatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton6.Location = new System.Drawing.Point(13, 160);
            this.flatButton6.Name = "flatButton6";
            this.flatButton6.Rounded = false;
            this.flatButton6.Size = new System.Drawing.Size(415, 50);
            this.flatButton6.TabIndex = 5;
            this.flatButton6.Text = "Reset MUSIX";
            this.flatButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.Transparent;
            this.flatButton5.BaseColor = System.Drawing.Color.DodgerBlue;
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton5.Location = new System.Drawing.Point(13, 92);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = false;
            this.flatButton5.Size = new System.Drawing.Size(415, 50);
            this.flatButton5.TabIndex = 4;
            this.flatButton5.Text = "MUSIX Repair";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.DodgerBlue;
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(13, 24);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(415, 50);
            this.flatButton4.TabIndex = 3;
            this.flatButton4.Text = "MUSIX Updator";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage5.Controls.Add(this.flatButton2);
            this.tabPage5.Controls.Add(this.flatButton1);
            this.tabPage5.Controls.Add(this.listBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(440, 475);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Music Path";
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.DodgerBlue;
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(326, 8);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(106, 32);
            this.flatButton2.TabIndex = 4;
            this.flatButton2.Text = "Remove";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.DodgerBlue;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(9, 8);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 3;
            this.flatButton1.Text = "Add";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage6.Controls.Add(this.flatButton3);
            this.tabPage6.Controls.Add(this.macTrackBar1);
            this.tabPage6.Controls.Add(this.macTrackBar3);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.macTrackBar2);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.ForeColor = System.Drawing.Color.LightGray;
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(440, 475);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Audio settings";
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.DodgerBlue;
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(132, 119);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(61, 24);
            this.flatButton3.TabIndex = 10;
            this.flatButton3.Text = "Reset";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // macTrackBar1
            // 
            this.macTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar1.Checked = false;
            this.macTrackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macTrackBar1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.macTrackBar1.ForeColor = System.Drawing.Color.LightGray;
            this.macTrackBar1.Location = new System.Drawing.Point(139, 6);
            this.macTrackBar1.Name = "macTrackBar1";
            this.macTrackBar1.Options = FlatUI.FlatToggle._Options.Style1;
            this.macTrackBar1.Size = new System.Drawing.Size(76, 33);
            this.macTrackBar1.TabIndex = 9;
            this.macTrackBar1.Text = "flatToggle1";
            this.macTrackBar1.CheckedChanged += new FlatUI.FlatToggle.CheckedChangedEventHandler(this.flatToggle1_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(447, 574);
            this.Controls.Add(this.formSkin2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(447, 574);
            this.MinimumSize = new System.Drawing.Size(447, 574);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.formSkin2.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        public XComponent.SliderBar.MACTrackBar macTrackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public XComponent.SliderBar.MACTrackBar macTrackBar3;
        private System.Windows.Forms.Label label3;
        private FlatUI.FormSkin formSkin2;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton1;
        private System.Windows.Forms.TabPage tabPage6;
        private FlatUI.FlatToggle macTrackBar1;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton6;
        private FlatUI.FlatButton flatButton5;
        private FlatUI.FlatButton flatButton4;
        private System.Windows.Forms.Button button1;
    }
}