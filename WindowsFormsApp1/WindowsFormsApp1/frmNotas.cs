using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dato1 = Convert.ToInt32(textBox1.Text);
            int dato2 = Convert.ToInt32(textBox2.Text);
            int r = dato1 + dato2;
            textBox3.Text = r.ToString();
        }
    }
}
