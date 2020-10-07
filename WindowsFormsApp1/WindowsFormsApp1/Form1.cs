using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dominio;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNotas frm = new frmNotas();
            Login login = new Login();
            clsLogin clsl = new clsLogin();
            login.User = txtUser.Text;
            login.Pass = txtContra.Text;
            Boolean ok= clsl.entrar(login);
            if (ok == true)
            {
                MessageBox.Show("WELCOME");
                frm.Show();
            }
            else {
                MessageBox.Show("Stop");
            }

        }
    }
}
