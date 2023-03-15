
namespace WinFormsExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.GeneralsettingGBox = new System.Windows.Forms.GroupBox();
            this.canclebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.SavedetailGBox = new System.Windows.Forms.GroupBox();
            this.serialtxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.savepathtxt = new System.Windows.Forms.TextBox();
            this.altserialtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GeneralPanel.SuspendLayout();
            this.GeneralsettingGBox.SuspendLayout();
            this.SavedetailGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.BackColor = System.Drawing.Color.Gray;
            this.GeneralPanel.Controls.Add(this.GeneralsettingGBox);
            this.GeneralPanel.Location = new System.Drawing.Point(0, 0);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(1119, 763);
            this.GeneralPanel.TabIndex = 1;
            // 
            // GeneralsettingGBox
            // 
            this.GeneralsettingGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralsettingGBox.Controls.Add(this.canclebtn);
            this.GeneralsettingGBox.Controls.Add(this.savebtn);
            this.GeneralsettingGBox.Controls.Add(this.SavedetailGBox);
            this.GeneralsettingGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralsettingGBox.ForeColor = System.Drawing.Color.Black;
            this.GeneralsettingGBox.Location = new System.Drawing.Point(12, 10);
            this.GeneralsettingGBox.Name = "GeneralsettingGBox";
            this.GeneralsettingGBox.Size = new System.Drawing.Size(1097, 740);
            this.GeneralsettingGBox.TabIndex = 0;
            this.GeneralsettingGBox.TabStop = false;
            this.GeneralsettingGBox.Text = "General Setting";
            // 
            // canclebtn
            // 
            this.canclebtn.BackColor = System.Drawing.Color.White;
            this.canclebtn.Image = ((System.Drawing.Image)(resources.GetObject("canclebtn.Image")));
            this.canclebtn.Location = new System.Drawing.Point(443, 182);
            this.canclebtn.Name = "canclebtn";
            this.canclebtn.Size = new System.Drawing.Size(40, 37);
            this.canclebtn.TabIndex = 4;
            this.canclebtn.UseVisualStyleBackColor = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.Location = new System.Drawing.Point(396, 182);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(40, 37);
            this.savebtn.TabIndex = 3;
            this.savebtn.UseVisualStyleBackColor = false;
            // 
            // SavedetailGBox
            // 
            this.SavedetailGBox.Controls.Add(this.serialtxt);
            this.SavedetailGBox.Controls.Add(this.button2);
            this.SavedetailGBox.Controls.Add(this.label3);
            this.SavedetailGBox.Controls.Add(this.checkBox2);
            this.SavedetailGBox.Controls.Add(this.checkBox1);
            this.SavedetailGBox.Controls.Add(this.savepathtxt);
            this.SavedetailGBox.Controls.Add(this.altserialtxt);
            this.SavedetailGBox.Controls.Add(this.label5);
            this.SavedetailGBox.Controls.Add(this.label4);
            this.SavedetailGBox.Location = new System.Drawing.Point(7, 19);
            this.SavedetailGBox.Name = "SavedetailGBox";
            this.SavedetailGBox.Size = new System.Drawing.Size(476, 157);
            this.SavedetailGBox.TabIndex = 1;
            this.SavedetailGBox.TabStop = false;
            this.SavedetailGBox.Text = "Save Detail";
            // 
            // serialtxt
            // 
            this.serialtxt.Location = new System.Drawing.Point(139, 25);
            this.serialtxt.Name = "serialtxt";
            this.serialtxt.Size = new System.Drawing.Size(290, 20);
            this.serialtxt.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(436, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 20);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Machine Serial Number";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(139, 130);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Front Viewer (Offline)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(139, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "360 Viewer(Offline)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // savepathtxt
            // 
            this.savepathtxt.Location = new System.Drawing.Point(140, 83);
            this.savepathtxt.Name = "savepathtxt";
            this.savepathtxt.Size = new System.Drawing.Size(290, 20);
            this.savepathtxt.TabIndex = 3;
            // 
            // altserialtxt
            // 
            this.altserialtxt.Location = new System.Drawing.Point(140, 55);
            this.altserialtxt.Name = "altserialtxt";
            this.altserialtxt.Size = new System.Drawing.Size(290, 20);
            this.altserialtxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alternative Serial Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Save Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 762);
            this.Controls.Add(this.GeneralPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralsettingGBox.ResumeLayout(false);
            this.SavedetailGBox.ResumeLayout(false);
            this.SavedetailGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.GroupBox GeneralsettingGBox;
        private System.Windows.Forms.Button canclebtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.GroupBox SavedetailGBox;
        private System.Windows.Forms.TextBox serialtxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox savepathtxt;
        private System.Windows.Forms.TextBox altserialtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}