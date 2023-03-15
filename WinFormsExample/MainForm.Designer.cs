using EOSDigital.SDK;
using System;
using System.Windows.Forms;

namespace WinFormsExample
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.KcoBox = new System.Windows.Forms.ComboBox();
            this.VIScombox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BulbUpDo = new System.Windows.Forms.NumericUpDown();
            this.button18 = new System.Windows.Forms.Button();
            this.Depthchbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FocusFar3Button = new System.Windows.Forms.Button();
            this.TvCoBox = new System.Windows.Forms.ComboBox();
            this.FocusFar2Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FocusNear3Button = new System.Windows.Forms.Button();
            this.FocusFar1Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FocusNear2Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FocusNear1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AvCoBox = new System.Windows.Forms.ComboBox();
            this.ISOCoBox = new System.Windows.Forms.ComboBox();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.CameraListBox = new System.Windows.Forms.ListBox();
            this.SavePathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SaveToGroupBox = new System.Windows.Forms.GroupBox();
            this.STBothRdButton = new System.Windows.Forms.RadioButton();
            this.STComputerRdButton = new System.Windows.Forms.RadioButton();
            this.STCameraRdButton = new System.Windows.Forms.RadioButton();
            this.RecordVideoButton = new System.Windows.Forms.Button();
            this.LiveViewButton = new System.Windows.Forms.Button();
            this.LiveViewPicBox = new System.Windows.Forms.PictureBox();
            this.SessionLabel = new System.Windows.Forms.Label();
            this.SessionButton = new System.Windows.Forms.Button();
            this.SaveFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblright45 = new System.Windows.Forms.Label();
            this.lbl360 = new System.Windows.Forms.Label();
            this.lbl180 = new System.Windows.Forms.Label();
            this.lblright90 = new System.Windows.Forms.Label();
            this.lblleft90 = new System.Windows.Forms.Label();
            this.lblleft45 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plusesquarebtn = new System.Windows.Forms.Button();
            this.verticalsquarebtn = new System.Windows.Forms.Button();
            this.horizontalsquarebtn = new System.Windows.Forms.Button();
            this.dotsquarebtn = new System.Windows.Forms.Button();
            this.squarebtn = new System.Windows.Forms.Button();
            this.subtractbtn = new System.Windows.Forms.Button();
            this.plusebtn = new System.Windows.Forms.Button();
            this.crpsetting = new System.Windows.Forms.NumericUpDown();
            this.rightcrbtn = new System.Windows.Forms.Button();
            this.UPcrpbtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.leftcrpbtn = new System.Windows.Forms.Button();
            this.downcrpbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TakePhotoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.remarktxt = new System.Windows.Forms.RichTextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulbUpDo)).BeginInit();
            this.SaveToGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crpsetting)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsGroupBox.BackColor = System.Drawing.Color.Gray;
            this.SettingsGroupBox.Controls.Add(this.KcoBox);
            this.SettingsGroupBox.Controls.Add(this.VIScombox);
            this.SettingsGroupBox.Controls.Add(this.label4);
            this.SettingsGroupBox.Controls.Add(this.BulbUpDo);
            this.SettingsGroupBox.Controls.Add(this.button18);
            this.SettingsGroupBox.Controls.Add(this.Depthchbox);
            this.SettingsGroupBox.Controls.Add(this.label7);
            this.SettingsGroupBox.Controls.Add(this.FocusFar3Button);
            this.SettingsGroupBox.Controls.Add(this.TvCoBox);
            this.SettingsGroupBox.Controls.Add(this.FocusFar2Button);
            this.SettingsGroupBox.Controls.Add(this.label3);
            this.SettingsGroupBox.Controls.Add(this.FocusNear3Button);
            this.SettingsGroupBox.Controls.Add(this.FocusFar1Button);
            this.SettingsGroupBox.Controls.Add(this.label2);
            this.SettingsGroupBox.Controls.Add(this.FocusNear2Button);
            this.SettingsGroupBox.Controls.Add(this.label6);
            this.SettingsGroupBox.Controls.Add(this.FocusNear1Button);
            this.SettingsGroupBox.Controls.Add(this.label1);
            this.SettingsGroupBox.Controls.Add(this.label5);
            this.SettingsGroupBox.Controls.Add(this.AvCoBox);
            this.SettingsGroupBox.Controls.Add(this.ISOCoBox);
            this.SettingsGroupBox.Controls.Add(this.MainProgressBar);
            this.SettingsGroupBox.Enabled = false;
            this.SettingsGroupBox.ForeColor = System.Drawing.Color.Black;
            this.SettingsGroupBox.Location = new System.Drawing.Point(8, 74);
            this.SettingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SettingsGroupBox.Size = new System.Drawing.Size(424, 207);
            this.SettingsGroupBox.TabIndex = 14;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Camera Setting";
            // 
            // KcoBox
            // 
            this.KcoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KcoBox.BackColor = System.Drawing.SystemColors.Window;
            this.KcoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KcoBox.ForeColor = System.Drawing.Color.Black;
            this.KcoBox.FormattingEnabled = true;
            this.KcoBox.Location = new System.Drawing.Point(43, 62);
            this.KcoBox.Margin = new System.Windows.Forms.Padding(4);
            this.KcoBox.Name = "KcoBox";
            this.KcoBox.Size = new System.Drawing.Size(88, 24);
            this.KcoBox.TabIndex = 19;
            this.KcoBox.SelectedIndexChanged += new System.EventHandler(this.KcoBox_SelectedIndexChanged);
            // 
            // VIScombox
            // 
            this.VIScombox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VIScombox.BackColor = System.Drawing.Color.White;
            this.VIScombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VIScombox.ForeColor = System.Drawing.Color.Black;
            this.VIScombox.FormattingEnabled = true;
            this.VIScombox.Location = new System.Drawing.Point(176, 62);
            this.VIScombox.Margin = new System.Windows.Forms.Padding(4);
            this.VIScombox.Name = "VIScombox";
            this.VIScombox.Size = new System.Drawing.Size(180, 24);
            this.VIScombox.TabIndex = 18;
            this.VIScombox.SelectedIndexChanged += new System.EventHandler(this.VIScombox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bulb (s)";
            // 
            // BulbUpDo
            // 
            this.BulbUpDo.Location = new System.Drawing.Point(353, 101);
            this.BulbUpDo.Margin = new System.Windows.Forms.Padding(4);
            this.BulbUpDo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BulbUpDo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BulbUpDo.Name = "BulbUpDo";
            this.BulbUpDo.Size = new System.Drawing.Size(61, 22);
            this.BulbUpDo.TabIndex = 16;
            this.BulbUpDo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(364, 57);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(51, 33);
            this.button18.TabIndex = 15;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // Depthchbox
            // 
            this.Depthchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Depthchbox.AutoSize = true;
            this.Depthchbox.Location = new System.Drawing.Point(27, 164);
            this.Depthchbox.Margin = new System.Windows.Forms.Padding(4);
            this.Depthchbox.Name = "Depthchbox";
            this.Depthchbox.Size = new System.Drawing.Size(68, 21);
            this.Depthchbox.TabIndex = 9;
            this.Depthchbox.Text = "Depth";
            this.Depthchbox.UseVisualStyleBackColor = true;
            this.Depthchbox.CheckedChanged += new System.EventHandler(this.Depthchbox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "VIS";
            // 
            // FocusFar3Button
            // 
            this.FocusFar3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusFar3Button.BackColor = System.Drawing.Color.White;
            this.FocusFar3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar3Button.ForeColor = System.Drawing.Color.Black;
            this.FocusFar3Button.Image = ((System.Drawing.Image)(resources.GetObject("FocusFar3Button.Image")));
            this.FocusFar3Button.Location = new System.Drawing.Point(363, 154);
            this.FocusFar3Button.Margin = new System.Windows.Forms.Padding(4);
            this.FocusFar3Button.Name = "FocusFar3Button";
            this.FocusFar3Button.Size = new System.Drawing.Size(47, 46);
            this.FocusFar3Button.TabIndex = 6;
            this.FocusFar3Button.UseVisualStyleBackColor = false;
            this.FocusFar3Button.Click += new System.EventHandler(this.FocusFar3Button_Click);
            // 
            // TvCoBox
            // 
            this.TvCoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TvCoBox.BackColor = System.Drawing.Color.White;
            this.TvCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TvCoBox.ForeColor = System.Drawing.Color.Black;
            this.TvCoBox.FormattingEnabled = true;
            this.TvCoBox.Location = new System.Drawing.Point(176, 23);
            this.TvCoBox.Margin = new System.Windows.Forms.Padding(4);
            this.TvCoBox.Name = "TvCoBox";
            this.TvCoBox.Size = new System.Drawing.Size(93, 24);
            this.TvCoBox.TabIndex = 0;
            this.TvCoBox.SelectedIndexChanged += new System.EventHandler(this.TvCoBox_SelectedIndexChanged);
            // 
            // FocusFar2Button
            // 
            this.FocusFar2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusFar2Button.BackColor = System.Drawing.Color.White;
            this.FocusFar2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar2Button.ForeColor = System.Drawing.Color.Black;
            this.FocusFar2Button.Image = ((System.Drawing.Image)(resources.GetObject("FocusFar2Button.Image")));
            this.FocusFar2Button.Location = new System.Drawing.Point(311, 154);
            this.FocusFar2Button.Margin = new System.Windows.Forms.Padding(4);
            this.FocusFar2Button.Name = "FocusFar2Button";
            this.FocusFar2Button.Size = new System.Drawing.Size(47, 46);
            this.FocusFar2Button.TabIndex = 6;
            this.FocusFar2Button.UseVisualStyleBackColor = false;
            this.FocusFar2Button.Click += new System.EventHandler(this.FocusFar2Button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(279, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISO";
            // 
            // FocusNear3Button
            // 
            this.FocusNear3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusNear3Button.BackColor = System.Drawing.Color.White;
            this.FocusNear3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear3Button.ForeColor = System.Drawing.Color.Black;
            this.FocusNear3Button.Image = ((System.Drawing.Image)(resources.GetObject("FocusNear3Button.Image")));
            this.FocusNear3Button.Location = new System.Drawing.Point(100, 154);
            this.FocusNear3Button.Margin = new System.Windows.Forms.Padding(4);
            this.FocusNear3Button.Name = "FocusNear3Button";
            this.FocusNear3Button.Size = new System.Drawing.Size(47, 46);
            this.FocusNear3Button.TabIndex = 6;
            this.FocusNear3Button.UseVisualStyleBackColor = false;
            this.FocusNear3Button.Click += new System.EventHandler(this.FocusNear3Button_Click);
            // 
            // FocusFar1Button
            // 
            this.FocusFar1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusFar1Button.BackColor = System.Drawing.Color.White;
            this.FocusFar1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar1Button.ForeColor = System.Drawing.Color.Black;
            this.FocusFar1Button.Image = ((System.Drawing.Image)(resources.GetObject("FocusFar1Button.Image")));
            this.FocusFar1Button.Location = new System.Drawing.Point(259, 154);
            this.FocusFar1Button.Margin = new System.Windows.Forms.Padding(4);
            this.FocusFar1Button.Name = "FocusFar1Button";
            this.FocusFar1Button.Size = new System.Drawing.Size(47, 46);
            this.FocusFar1Button.TabIndex = 6;
            this.FocusFar1Button.UseVisualStyleBackColor = false;
            this.FocusFar1Button.Click += new System.EventHandler(this.FocusFar1Button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(136, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tv";
            // 
            // FocusNear2Button
            // 
            this.FocusNear2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusNear2Button.BackColor = System.Drawing.Color.White;
            this.FocusNear2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear2Button.ForeColor = System.Drawing.Color.Black;
            this.FocusNear2Button.Image = ((System.Drawing.Image)(resources.GetObject("FocusNear2Button.Image")));
            this.FocusNear2Button.Location = new System.Drawing.Point(155, 154);
            this.FocusNear2Button.Margin = new System.Windows.Forms.Padding(4);
            this.FocusNear2Button.Name = "FocusNear2Button";
            this.FocusNear2Button.Size = new System.Drawing.Size(47, 46);
            this.FocusNear2Button.TabIndex = 6;
            this.FocusNear2Button.UseVisualStyleBackColor = false;
            this.FocusNear2Button.Click += new System.EventHandler(this.FocusNear2Button_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "K";
            // 
            // FocusNear1Button
            // 
            this.FocusNear1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusNear1Button.BackColor = System.Drawing.Color.White;
            this.FocusNear1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear1Button.ForeColor = System.Drawing.Color.Black;
            this.FocusNear1Button.Image = ((System.Drawing.Image)(resources.GetObject("FocusNear1Button.Image")));
            this.FocusNear1Button.Location = new System.Drawing.Point(205, 154);
            this.FocusNear1Button.Margin = new System.Windows.Forms.Padding(4);
            this.FocusNear1Button.Name = "FocusNear1Button";
            this.FocusNear1Button.Size = new System.Drawing.Size(47, 46);
            this.FocusNear1Button.TabIndex = 6;
            this.FocusNear1Button.UseVisualStyleBackColor = false;
            this.FocusNear1Button.Click += new System.EventHandler(this.FocusNear1Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Av";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Focusing Panel";
            // 
            // AvCoBox
            // 
            this.AvCoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvCoBox.BackColor = System.Drawing.SystemColors.Window;
            this.AvCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvCoBox.ForeColor = System.Drawing.Color.Black;
            this.AvCoBox.FormattingEnabled = true;
            this.AvCoBox.Location = new System.Drawing.Point(43, 25);
            this.AvCoBox.Margin = new System.Windows.Forms.Padding(4);
            this.AvCoBox.Name = "AvCoBox";
            this.AvCoBox.Size = new System.Drawing.Size(88, 24);
            this.AvCoBox.TabIndex = 0;
            this.AvCoBox.SelectedIndexChanged += new System.EventHandler(this.AvCoBox_SelectedIndexChanged);
            // 
            // ISOCoBox
            // 
            this.ISOCoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISOCoBox.BackColor = System.Drawing.Color.White;
            this.ISOCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISOCoBox.ForeColor = System.Drawing.Color.Black;
            this.ISOCoBox.FormattingEnabled = true;
            this.ISOCoBox.Location = new System.Drawing.Point(321, 23);
            this.ISOCoBox.Margin = new System.Windows.Forms.Padding(4);
            this.ISOCoBox.Name = "ISOCoBox";
            this.ISOCoBox.Size = new System.Drawing.Size(91, 24);
            this.ISOCoBox.TabIndex = 0;
            this.ISOCoBox.SelectedIndexChanged += new System.EventHandler(this.ISOCoBox_SelectedIndexChanged);
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainProgressBar.BackColor = System.Drawing.Color.White;
            this.MainProgressBar.Location = new System.Drawing.Point(8, 97);
            this.MainProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(265, 28);
            this.MainProgressBar.TabIndex = 8;
            // 
            // CameraListBox
            // 
            this.CameraListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraListBox.BackColor = System.Drawing.Color.Gray;
            this.CameraListBox.FormattingEnabled = true;
            this.CameraListBox.ItemHeight = 16;
            this.CameraListBox.Location = new System.Drawing.Point(8, 9);
            this.CameraListBox.Margin = new System.Windows.Forms.Padding(4);
            this.CameraListBox.Name = "CameraListBox";
            this.CameraListBox.Size = new System.Drawing.Size(423, 52);
            this.CameraListBox.TabIndex = 6;
            // 
            // SavePathTextBox
            // 
            this.SavePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePathTextBox.BackColor = System.Drawing.Color.White;
            this.SavePathTextBox.Enabled = false;
            this.SavePathTextBox.ForeColor = System.Drawing.Color.Black;
            this.SavePathTextBox.Location = new System.Drawing.Point(4, 30);
            this.SavePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SavePathTextBox.Name = "SavePathTextBox";
            this.SavePathTextBox.Size = new System.Drawing.Size(205, 22);
            this.SavePathTextBox.TabIndex = 6;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BrowseButton.Enabled = false;
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.Location = new System.Drawing.Point(213, 20);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(96, 38);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SaveToGroupBox
            // 
            this.SaveToGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToGroupBox.Controls.Add(this.STBothRdButton);
            this.SaveToGroupBox.Controls.Add(this.STComputerRdButton);
            this.SaveToGroupBox.Controls.Add(this.STCameraRdButton);
            this.SaveToGroupBox.ForeColor = System.Drawing.Color.Black;
            this.SaveToGroupBox.Location = new System.Drawing.Point(8, 62);
            this.SaveToGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SaveToGroupBox.Name = "SaveToGroupBox";
            this.SaveToGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SaveToGroupBox.Size = new System.Drawing.Size(400, 54);
            this.SaveToGroupBox.TabIndex = 4;
            this.SaveToGroupBox.TabStop = false;
            this.SaveToGroupBox.Text = "Save To";
            // 
            // STBothRdButton
            // 
            this.STBothRdButton.AutoSize = true;
            this.STBothRdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STBothRdButton.Location = new System.Drawing.Point(248, 21);
            this.STBothRdButton.Margin = new System.Windows.Forms.Padding(4);
            this.STBothRdButton.Name = "STBothRdButton";
            this.STBothRdButton.Size = new System.Drawing.Size(65, 24);
            this.STBothRdButton.TabIndex = 0;
            this.STBothRdButton.Text = "Both";
            this.STBothRdButton.UseVisualStyleBackColor = true;
            this.STBothRdButton.CheckedChanged += new System.EventHandler(this.SaveToRdButton_CheckedChanged);
            // 
            // STComputerRdButton
            // 
            this.STComputerRdButton.AutoSize = true;
            this.STComputerRdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STComputerRdButton.Location = new System.Drawing.Point(128, 21);
            this.STComputerRdButton.Margin = new System.Windows.Forms.Padding(4);
            this.STComputerRdButton.Name = "STComputerRdButton";
            this.STComputerRdButton.Size = new System.Drawing.Size(103, 24);
            this.STComputerRdButton.TabIndex = 0;
            this.STComputerRdButton.Text = "Computer";
            this.STComputerRdButton.UseVisualStyleBackColor = true;
            this.STComputerRdButton.CheckedChanged += new System.EventHandler(this.SaveToRdButton_CheckedChanged);
            // 
            // STCameraRdButton
            // 
            this.STCameraRdButton.AutoSize = true;
            this.STCameraRdButton.Checked = true;
            this.STCameraRdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STCameraRdButton.Location = new System.Drawing.Point(17, 21);
            this.STCameraRdButton.Margin = new System.Windows.Forms.Padding(4);
            this.STCameraRdButton.Name = "STCameraRdButton";
            this.STCameraRdButton.Size = new System.Drawing.Size(89, 24);
            this.STCameraRdButton.TabIndex = 0;
            this.STCameraRdButton.TabStop = true;
            this.STCameraRdButton.Text = "Camera";
            this.STCameraRdButton.UseVisualStyleBackColor = true;
            this.STCameraRdButton.CheckedChanged += new System.EventHandler(this.SaveToRdButton_CheckedChanged);
            // 
            // RecordVideoButton
            // 
            this.RecordVideoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordVideoButton.BackColor = System.Drawing.Color.White;
            this.RecordVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordVideoButton.ForeColor = System.Drawing.Color.Black;
            this.RecordVideoButton.Image = ((System.Drawing.Image)(resources.GetObject("RecordVideoButton.Image")));
            this.RecordVideoButton.Location = new System.Drawing.Point(79, 16);
            this.RecordVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.RecordVideoButton.Name = "RecordVideoButton";
            this.RecordVideoButton.Size = new System.Drawing.Size(57, 49);
            this.RecordVideoButton.TabIndex = 2;
            this.RecordVideoButton.UseVisualStyleBackColor = false;
            this.RecordVideoButton.Click += new System.EventHandler(this.RecordVideoButton_Click);
            // 
            // LiveViewButton
            // 
            this.LiveViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveViewButton.BackColor = System.Drawing.Color.White;
            this.LiveViewButton.ForeColor = System.Drawing.Color.White;
            this.LiveViewButton.Image = ((System.Drawing.Image)(resources.GetObject("LiveViewButton.Image")));
            this.LiveViewButton.Location = new System.Drawing.Point(144, 16);
            this.LiveViewButton.Margin = new System.Windows.Forms.Padding(4);
            this.LiveViewButton.Name = "LiveViewButton";
            this.LiveViewButton.Size = new System.Drawing.Size(57, 49);
            this.LiveViewButton.TabIndex = 2;
            this.LiveViewButton.UseVisualStyleBackColor = false;
            this.LiveViewButton.Click += new System.EventHandler(this.LiveViewButton_Click);
            // 
            // LiveViewPicBox
            // 
            this.LiveViewPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveViewPicBox.BackColor = System.Drawing.Color.DimGray;
            this.LiveViewPicBox.Location = new System.Drawing.Point(0, 127);
            this.LiveViewPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.LiveViewPicBox.Name = "LiveViewPicBox";
            this.LiveViewPicBox.Size = new System.Drawing.Size(1045, 845);
            this.LiveViewPicBox.TabIndex = 7;
            this.LiveViewPicBox.TabStop = false;
            this.LiveViewPicBox.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.LiveViewPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.LiveViewPicBox_Paint);
            this.LiveViewPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.LiveViewPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // SessionLabel
            // 
            this.SessionLabel.AutoSize = true;
            this.SessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionLabel.Location = new System.Drawing.Point(6, 16);
            this.SessionLabel.Name = "SessionLabel";
            this.SessionLabel.Size = new System.Drawing.Size(110, 16);
            this.SessionLabel.TabIndex = 8;
            this.SessionLabel.Text = "No open session";
            // 
            // SessionButton
            // 
            this.SessionButton.Location = new System.Drawing.Point(0, 0);
            this.SessionButton.Name = "SessionButton";
            this.SessionButton.Size = new System.Drawing.Size(75, 23);
            this.SessionButton.TabIndex = 0;
            this.SessionButton.Click += new System.EventHandler(this.SessionButton_Click);
            // 
            // SaveFolderBrowser
            // 
            this.SaveFolderBrowser.Description = "Save Images To...";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.CameraListBox);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.SettingsGroupBox);
            this.panel1.Location = new System.Drawing.Point(1049, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 981);
            this.panel1.TabIndex = 15;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.Gray;
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Controls.Add(this.SavePathTextBox);
            this.groupBox6.Controls.Add(this.BrowseButton);
            this.groupBox6.Controls.Add(this.SaveToGroupBox);
            this.groupBox6.Location = new System.Drawing.Point(12, 853);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(417, 124);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Overlay";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(312, 20);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 42);
            this.button12.TabIndex = 7;
            this.button12.Text = "File Save";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Gray;
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.images);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Location = new System.Drawing.Point(12, 778);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(417, 68);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Staking";
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(337, 23);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 37);
            this.button11.TabIndex = 17;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // images
            // 
            this.images.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.images.BackColor = System.Drawing.Color.White;
            this.images.ForeColor = System.Drawing.Color.Black;
            this.images.Location = new System.Drawing.Point(247, 30);
            this.images.Margin = new System.Windows.Forms.Padding(4);
            this.images.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.images.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(83, 22);
            this.images.TabIndex = 16;
            this.images.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(181, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Images";
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(89, 23);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 37);
            this.button10.TabIndex = 1;
            this.button10.Text = "FocusB";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(7, 23);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 37);
            this.button9.TabIndex = 0;
            this.button9.Text = "FocusA";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Location = new System.Drawing.Point(12, 718);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(417, 53);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Light Profile / Vision Profile";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "VISION_A",
            "VISION_B",
            "VISION_C",
            "VISION_D",
            "VISION_E",
            "VISION_H&A",
            "VISION_TRUE_WHITE"});
            this.comboBox4.Location = new System.Drawing.Point(224, 20);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(184, 24);
            this.comboBox4.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "LIGHT_PROFILE"});
            this.comboBox3.Location = new System.Drawing.Point(8, 20);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(201, 24);
            this.comboBox3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.lblright45);
            this.groupBox3.Controls.Add(this.lbl360);
            this.groupBox3.Controls.Add(this.lbl180);
            this.groupBox3.Controls.Add(this.lblright90);
            this.groupBox3.Controls.Add(this.lblleft90);
            this.groupBox3.Controls.Add(this.lblleft45);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 603);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(415, 107);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotation";
            // 
            // lblright45
            // 
            this.lblright45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblright45.AutoSize = true;
            this.lblright45.Image = ((System.Drawing.Image)(resources.GetObject("lblright45.Image")));
            this.lblright45.Location = new System.Drawing.Point(140, 79);
            this.lblright45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblright45.Name = "lblright45";
            this.lblright45.Size = new System.Drawing.Size(44, 17);
            this.lblright45.TabIndex = 12;
            this.lblright45.Text = "45     ";
            this.lblright45.Click += new System.EventHandler(this.lblright45_Click);
            // 
            // lbl360
            // 
            this.lbl360.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl360.AutoSize = true;
            this.lbl360.Location = new System.Drawing.Point(372, 79);
            this.lbl360.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl360.Name = "lbl360";
            this.lbl360.Size = new System.Drawing.Size(32, 17);
            this.lbl360.TabIndex = 11;
            this.lbl360.Text = "360";
            this.lbl360.Click += new System.EventHandler(this.lbl360_Click);
            // 
            // lbl180
            // 
            this.lbl180.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl180.AutoSize = true;
            this.lbl180.ForeColor = System.Drawing.Color.Black;
            this.lbl180.Location = new System.Drawing.Point(319, 79);
            this.lbl180.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl180.Name = "lbl180";
            this.lbl180.Size = new System.Drawing.Size(32, 17);
            this.lbl180.TabIndex = 10;
            this.lbl180.Text = "180";
            this.lbl180.Click += new System.EventHandler(this.lbl180_Click);
            // 
            // lblright90
            // 
            this.lblright90.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblright90.AutoSize = true;
            this.lblright90.Image = ((System.Drawing.Image)(resources.GetObject("lblright90.Image")));
            this.lblright90.Location = new System.Drawing.Point(253, 79);
            this.lblright90.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblright90.Name = "lblright90";
            this.lblright90.Size = new System.Drawing.Size(44, 17);
            this.lblright90.TabIndex = 9;
            this.lblright90.Text = "90     ";
            this.lblright90.Click += new System.EventHandler(this.lblright90_Click);
            // 
            // lblleft90
            // 
            this.lblleft90.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblleft90.AutoSize = true;
            this.lblleft90.Image = ((System.Drawing.Image)(resources.GetObject("lblleft90.Image")));
            this.lblleft90.Location = new System.Drawing.Point(192, 79);
            this.lblleft90.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblleft90.Name = "lblleft90";
            this.lblleft90.Size = new System.Drawing.Size(48, 17);
            this.lblleft90.TabIndex = 8;
            this.lblleft90.Text = "      90";
            this.lblleft90.Click += new System.EventHandler(this.lblleft90_Click);
            // 
            // lblleft45
            // 
            this.lblleft45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblleft45.Image = ((System.Drawing.Image)(resources.GetObject("lblleft45.Image")));
            this.lblleft45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblleft45.Location = new System.Drawing.Point(84, 79);
            this.lblleft45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblleft45.Name = "lblleft45";
            this.lblleft45.Size = new System.Drawing.Size(45, 16);
            this.lblleft45.TabIndex = 6;
            this.lblleft45.Text = "     45";
            this.lblleft45.Click += new System.EventHandler(this.lblleft45_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(353, 25);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 43);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(299, 25);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 43);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(68, 25);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 43);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(8, 25);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 43);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(164, 37);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.plusesquarebtn);
            this.groupBox2.Controls.Add(this.verticalsquarebtn);
            this.groupBox2.Controls.Add(this.horizontalsquarebtn);
            this.groupBox2.Controls.Add(this.dotsquarebtn);
            this.groupBox2.Controls.Add(this.squarebtn);
            this.groupBox2.Controls.Add(this.subtractbtn);
            this.groupBox2.Controls.Add(this.plusebtn);
            this.groupBox2.Controls.Add(this.crpsetting);
            this.groupBox2.Controls.Add(this.rightcrbtn);
            this.groupBox2.Controls.Add(this.UPcrpbtn);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.leftcrpbtn);
            this.groupBox2.Controls.Add(this.downcrpbtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 441);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(417, 155);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crop Setting";
            // 
            // plusesquarebtn
            // 
            this.plusesquarebtn.Image = ((System.Drawing.Image)(resources.GetObject("plusesquarebtn.Image")));
            this.plusesquarebtn.Location = new System.Drawing.Point(337, 121);
            this.plusesquarebtn.Margin = new System.Windows.Forms.Padding(4);
            this.plusesquarebtn.Name = "plusesquarebtn";
            this.plusesquarebtn.Size = new System.Drawing.Size(29, 27);
            this.plusesquarebtn.TabIndex = 24;
            this.plusesquarebtn.UseVisualStyleBackColor = true;
            this.plusesquarebtn.Click += new System.EventHandler(this.plusesquarebtn_Click);
            // 
            // verticalsquarebtn
            // 
            this.verticalsquarebtn.Image = ((System.Drawing.Image)(resources.GetObject("verticalsquarebtn.Image")));
            this.verticalsquarebtn.Location = new System.Drawing.Point(337, 96);
            this.verticalsquarebtn.Margin = new System.Windows.Forms.Padding(4);
            this.verticalsquarebtn.Name = "verticalsquarebtn";
            this.verticalsquarebtn.Size = new System.Drawing.Size(29, 27);
            this.verticalsquarebtn.TabIndex = 23;
            this.verticalsquarebtn.UseVisualStyleBackColor = true;
            this.verticalsquarebtn.Click += new System.EventHandler(this.verticalsquarebtn_Click);
            // 
            // horizontalsquarebtn
            // 
            this.horizontalsquarebtn.Image = ((System.Drawing.Image)(resources.GetObject("horizontalsquarebtn.Image")));
            this.horizontalsquarebtn.Location = new System.Drawing.Point(337, 69);
            this.horizontalsquarebtn.Margin = new System.Windows.Forms.Padding(4);
            this.horizontalsquarebtn.Name = "horizontalsquarebtn";
            this.horizontalsquarebtn.Size = new System.Drawing.Size(29, 27);
            this.horizontalsquarebtn.TabIndex = 22;
            this.horizontalsquarebtn.UseVisualStyleBackColor = true;
            this.horizontalsquarebtn.Click += new System.EventHandler(this.horizontalsquarebtn_Click);
            // 
            // dotsquarebtn
            // 
            this.dotsquarebtn.Image = ((System.Drawing.Image)(resources.GetObject("dotsquarebtn.Image")));
            this.dotsquarebtn.Location = new System.Drawing.Point(337, 42);
            this.dotsquarebtn.Margin = new System.Windows.Forms.Padding(4);
            this.dotsquarebtn.Name = "dotsquarebtn";
            this.dotsquarebtn.Size = new System.Drawing.Size(29, 27);
            this.dotsquarebtn.TabIndex = 21;
            this.dotsquarebtn.UseVisualStyleBackColor = true;
            this.dotsquarebtn.Click += new System.EventHandler(this.dotsquarebtn_Click);
            // 
            // squarebtn
            // 
            this.squarebtn.Image = ((System.Drawing.Image)(resources.GetObject("squarebtn.Image")));
            this.squarebtn.Location = new System.Drawing.Point(337, 14);
            this.squarebtn.Margin = new System.Windows.Forms.Padding(4);
            this.squarebtn.Name = "squarebtn";
            this.squarebtn.Size = new System.Drawing.Size(29, 27);
            this.squarebtn.TabIndex = 20;
            this.squarebtn.UseVisualStyleBackColor = true;
            this.squarebtn.Click += new System.EventHandler(this.squarebtn_Click);
            // 
            // subtractbtn
            // 
            this.subtractbtn.Image = ((System.Drawing.Image)(resources.GetObject("subtractbtn.Image")));
            this.subtractbtn.Location = new System.Drawing.Point(281, 65);
            this.subtractbtn.Margin = new System.Windows.Forms.Padding(4);
            this.subtractbtn.Name = "subtractbtn";
            this.subtractbtn.Size = new System.Drawing.Size(33, 28);
            this.subtractbtn.TabIndex = 19;
            this.subtractbtn.UseVisualStyleBackColor = true;
            this.subtractbtn.Click += new System.EventHandler(this.subtractbtn_Click);
            // 
            // plusebtn
            // 
            this.plusebtn.Image = ((System.Drawing.Image)(resources.GetObject("plusebtn.Image")));
            this.plusebtn.Location = new System.Drawing.Point(155, 65);
            this.plusebtn.Margin = new System.Windows.Forms.Padding(4);
            this.plusebtn.Name = "plusebtn";
            this.plusebtn.Size = new System.Drawing.Size(33, 28);
            this.plusebtn.TabIndex = 18;
            this.plusebtn.UseVisualStyleBackColor = true;
            this.plusebtn.Click += new System.EventHandler(this.plusebtn_Click);
            // 
            // crpsetting
            // 
            this.crpsetting.Location = new System.Drawing.Point(196, 65);
            this.crpsetting.Margin = new System.Windows.Forms.Padding(4);
            this.crpsetting.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.crpsetting.Name = "crpsetting";
            this.crpsetting.Size = new System.Drawing.Size(80, 22);
            this.crpsetting.TabIndex = 17;
            this.crpsetting.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // rightcrbtn
            // 
            this.rightcrbtn.Image = ((System.Drawing.Image)(resources.GetObject("rightcrbtn.Image")));
            this.rightcrbtn.Location = new System.Drawing.Point(99, 66);
            this.rightcrbtn.Margin = new System.Windows.Forms.Padding(4);
            this.rightcrbtn.Name = "rightcrbtn";
            this.rightcrbtn.Size = new System.Drawing.Size(31, 28);
            this.rightcrbtn.TabIndex = 14;
            this.rightcrbtn.UseVisualStyleBackColor = true;
            this.rightcrbtn.Click += new System.EventHandler(this.rightcrbtn_Click);
            // 
            // UPcrpbtn
            // 
            this.UPcrpbtn.Image = ((System.Drawing.Image)(resources.GetObject("UPcrpbtn.Image")));
            this.UPcrpbtn.Location = new System.Drawing.Point(68, 42);
            this.UPcrpbtn.Margin = new System.Windows.Forms.Padding(4);
            this.UPcrpbtn.Name = "UPcrpbtn";
            this.UPcrpbtn.Size = new System.Drawing.Size(31, 28);
            this.UPcrpbtn.TabIndex = 11;
            this.UPcrpbtn.UseVisualStyleBackColor = true;
            this.UPcrpbtn.Click += new System.EventHandler(this.UPcrpbtn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 69);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(31, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // leftcrpbtn
            // 
            this.leftcrpbtn.Image = ((System.Drawing.Image)(resources.GetObject("leftcrpbtn.Image")));
            this.leftcrpbtn.Location = new System.Drawing.Point(39, 66);
            this.leftcrpbtn.Margin = new System.Windows.Forms.Padding(4);
            this.leftcrpbtn.Name = "leftcrpbtn";
            this.leftcrpbtn.Size = new System.Drawing.Size(31, 28);
            this.leftcrpbtn.TabIndex = 12;
            this.leftcrpbtn.UseVisualStyleBackColor = true;
            this.leftcrpbtn.Click += new System.EventHandler(this.leftcrpbtn_Click);
            // 
            // downcrpbtn
            // 
            this.downcrpbtn.Image = ((System.Drawing.Image)(resources.GetObject("downcrpbtn.Image")));
            this.downcrpbtn.Location = new System.Drawing.Point(68, 94);
            this.downcrpbtn.Margin = new System.Windows.Forms.Padding(4);
            this.downcrpbtn.Name = "downcrpbtn";
            this.downcrpbtn.Size = new System.Drawing.Size(31, 28);
            this.downcrpbtn.TabIndex = 13;
            this.downcrpbtn.UseVisualStyleBackColor = true;
            this.downcrpbtn.Click += new System.EventHandler(this.downcrpbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.LiveViewButton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.TakePhotoButton);
            this.groupBox1.Controls.Add(this.RecordVideoButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(417, 145);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 82);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(345, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(352, 16);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 49);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(283, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 49);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(213, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 49);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TakePhotoButton
            // 
            this.TakePhotoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TakePhotoButton.BackColor = System.Drawing.Color.White;
            this.TakePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakePhotoButton.ForeColor = System.Drawing.Color.Black;
            this.TakePhotoButton.Image = ((System.Drawing.Image)(resources.GetObject("TakePhotoButton.Image")));
            this.TakePhotoButton.Location = new System.Drawing.Point(8, 16);
            this.TakePhotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.TakePhotoButton.Name = "TakePhotoButton";
            this.TakePhotoButton.Size = new System.Drawing.Size(57, 49);
            this.TakePhotoButton.TabIndex = 2;
            this.TakePhotoButton.UseVisualStyleBackColor = false;
            this.TakePhotoButton.Click += new System.EventHandler(this.TakePhotoButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(964, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 54);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.groupBox7);
            this.panel4.Controls.Add(this.LiveViewPicBox);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 981);
            this.panel4.TabIndex = 18;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.Gray;
            this.groupBox7.Controls.Add(this.button14);
            this.groupBox7.Controls.Add(this.button13);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.button17);
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Controls.Add(this.remarktxt);
            this.groupBox7.Controls.Add(this.idtxt);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(4, 0);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(1037, 119);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Movie Detail";
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(837, 62);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(41, 49);
            this.button14.TabIndex = 12;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(788, 62);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(41, 49);
            this.button13.TabIndex = 11;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(964, 65);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(57, 49);
            this.button17.TabIndex = 9;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(793, 37);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Photo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // remarktxt
            // 
            this.remarktxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remarktxt.Location = new System.Drawing.Point(527, 49);
            this.remarktxt.Margin = new System.Windows.Forms.Padding(4);
            this.remarktxt.Name = "remarktxt";
            this.remarktxt.Size = new System.Drawing.Size(252, 61);
            this.remarktxt.TabIndex = 6;
            this.remarktxt.Text = "";
            // 
            // idtxt
            // 
            this.idtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idtxt.Location = new System.Drawing.Point(527, 20);
            this.idtxt.Margin = new System.Windows.Forms.Padding(4);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(252, 22);
            this.idtxt.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(441, 50);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Remark";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(437, 21);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "Name/ID";
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 53);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dopis";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "360°";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.radioButton8);
            this.groupBox8.Controls.Add(this.radioButton7);
            this.groupBox8.Controls.Add(this.radioButton6);
            this.groupBox8.Controls.Add(this.radioButton5);
            this.groupBox8.Controls.Add(this.radioButton4);
            this.groupBox8.Controls.Add(this.radioButton3);
            this.groupBox8.Location = new System.Drawing.Point(101, 14);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(327, 76);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // radioButton8
            // 
            this.radioButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(228, 41);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(85, 21);
            this.radioButton8.TabIndex = 5;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Excellent";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(108, 41);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(67, 21);
            this.radioButton7.TabIndex = 4;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Finest";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(8, 42);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(59, 21);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Ideal";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(228, 10);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(57, 21);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Best";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(108, 10);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 21);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Seandard";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 11);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Normal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(8, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 976);
            this.panel3.TabIndex = 18;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(8, 90);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 68);
            this.button15.TabIndex = 4;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(8, 167);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 68);
            this.button16.TabIndex = 2;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(4, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 66);
            this.label15.TabIndex = 1;
            this.label15.Text = "SPR";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(145, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1492, 989);
            this.panel2.TabIndex = 19;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1640, 1001);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "SPR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulbUpDo)).EndInit();
            this.SaveToGroupBox.ResumeLayout(false);
            this.SaveToGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crpsetting)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.ProgressBar MainProgressBar;
        private System.Windows.Forms.TextBox SavePathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.GroupBox SaveToGroupBox;
        private System.Windows.Forms.RadioButton STBothRdButton;
        private System.Windows.Forms.RadioButton STComputerRdButton;
        private System.Windows.Forms.RadioButton STCameraRdButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RecordVideoButton;
        private System.Windows.Forms.ComboBox ISOCoBox;
        private System.Windows.Forms.ComboBox TvCoBox;
        private System.Windows.Forms.ComboBox AvCoBox;
        private System.Windows.Forms.Button FocusFar3Button;
        private System.Windows.Forms.Button FocusFar2Button;
        private System.Windows.Forms.Button FocusFar1Button;
        private System.Windows.Forms.Button FocusNear1Button;
        private System.Windows.Forms.Button FocusNear2Button;
        private System.Windows.Forms.Button FocusNear3Button;
        private System.Windows.Forms.Button LiveViewButton;
        private System.Windows.Forms.ListBox CameraListBox;
        private System.Windows.Forms.Label SessionLabel;
        private System.Windows.Forms.Button SessionButton;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowser;
        private PictureBox LiveViewPicBox;
        private Label label5;
        private CheckBox Depthchbox;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Button button6;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label lblright45;
        private Label lbl360;
        private Label lbl180;
        private Label lblright90;
        private Label lblleft90;
        private Label lblleft45;
        private Button button8;
        private Button button7;
        private GroupBox groupBox5;
        private Button button11;
        private NumericUpDown images;
        private Label label14;
        private Button button10;
        private Button button9;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Panel panel4;
        private Panel panel3;
        private Button button16;
        private Label label15;
        private GroupBox groupBox7;
        private Button button14;
        private Button button13;
        private CheckBox checkBox1;
        private Button button17;
        private RichTextBox remarktxt;
        private TextBox idtxt;
        private Label label16;
        private Label label17;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox8;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Panel panel2;
        private Button TakePhotoButton;
        private Button button15;
        private Button button18;
        private NumericUpDown BulbUpDo;
        private Label label4;
        private Button rightcrbtn;
        private Button downcrpbtn;
        private Button leftcrpbtn;
        private Button UPcrpbtn;
        private TextBox textBox4;
        private Button subtractbtn;
        private Button plusebtn;
        private NumericUpDown crpsetting;
        private Button plusesquarebtn;
        private Button verticalsquarebtn;
        private Button horizontalsquarebtn;
        private Button dotsquarebtn;
        private Button squarebtn;
        private Button button12;
        private System.IO.Ports.SerialPort serialPort1;
        private Label label8;
        private TrackBar trackBar1;
        private ComboBox VIScombox;
        private ComboBox KcoBox;
    }
}

