using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsExample
{
    public partial class speed : Form
    {
        public speed()
        {
            InitializeComponent();
        }

       

        private void speed_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void speed_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0" + textBox1.Text + " ," + textBox2.Text + " ," + textBox3.Text);
            serialPort1.Write("1" + textBox1.Text + " ," + textBox2.Text + " ," + textBox3.Text);
            serialPort1.Write("2" + textBox1.Text + " ," + textBox2.Text + " ," + textBox3.Text);
            // serialPort1.Write("r" + textBox1.Text + " ," + textBox2.Text + " ," + textBox3.Text);
            //   serialPort1.Write("l" + textBox1.Text + " ," + textBox2.Text + " ," + textBox3.Text);

        }

    }
}
