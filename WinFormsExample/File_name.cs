using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsExample
{
    public partial class File_name : Form
    {
        public File_name()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;

           



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (comboBox1.Text == "Do not modify")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                label9.Visible = false;
                label8.Visible = false;

            }
          else if(comboBox1.Text == "Prefix + Number")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                label9.Visible = true;
                label8.Visible = true;
                label9.Text += textBox1.Text + textBox2.Text;
                label9.Text = "spr_0001.xxx";
                
               // label9.Text=("textBox1.Text");
               // Label9.Text = TextBox1.Text;
            }
            else if(comboBox1.Text == "Shooting Date + Number")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                label9.Visible = true;
                label8.Visible = true;
                label9.Text += textBox1.Text + textBox2.Text;
                label9.Text = "22_09_2022_0001.xxx";
            }
            else if(comboBox1.Text == "Prefix + Shooting Date + Number")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                label9.Visible = true;
                label8.Visible = true;
                label9.Text += textBox1.Text + textBox2.Text;
                label9.Text = "spr_22_09_2022_0001.xxx";
            }
            else if(comboBox1.Text == "Shooting Date + Prefix + Number")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                label9.Visible = true;
                label8.Visible = true;
                label9.Text += textBox1.Text + textBox2.Text;
                label9.Text = "22_09_2022_spr_0001.xxx";
            }
            else if(comboBox1.Text == "Camera model + Number")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                label9.Visible = true;
                label8.Visible = true;
                label9.Text += textBox1.Text + textBox2.Text;
                label9.Text = "EOS xxD_0001.xxx";
            }
            else
            {
                label9.Text = "spr_0000.xxx";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Underline")
            {
                label9.Text = "_";
            }
            else if (comboBox1.Text == "Hyphen")
            {
                label9.Text = "-";
            }
            else
            {
                label9.Text = "";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label9.Text = textBox1.Text;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Underline")
            {

            }
        }

    }
}
