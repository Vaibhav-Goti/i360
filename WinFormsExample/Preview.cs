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
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void levelbtn_Click(object sender, EventArgs e)
        {
            original_image newForm = new original_image();
            newForm.ShowDialog();
        }
    }
}
