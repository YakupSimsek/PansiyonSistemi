using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonSistemi
{
    public partial class Menuler : Form
    {
        public Menuler()
        {
            InitializeComponent();
        }
         public string kullanıcı;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            FormGiris fr = new FormGiris();
            fr.Show();
            this.Hide();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToString("G");
        }

        private void Menuler_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblkullanıcı.Text = kullanıcı;
        }
    }
}
