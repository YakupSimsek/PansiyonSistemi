using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;

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
           Giris fr = new Giris();
            fr.Show();
            this.Hide();
        }
        private void panelharaket(Control btn)
        {
            pnlharaket.Top = btn.Top;
            pnlharaket.Height = btn.Height;
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
        private Form activeForm = null;
        private void anapanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlana.Controls.Add(childForm);
            pnlana.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void btnayarlar_Click(object sender, EventArgs e)
        {
           btnmusteri.FillColor = Color.FromArgb(125, 206, 19);
            btnayarlar.FillColor = Color.FromArgb(43, 122, 11);
            panelharaket(btnayarlar);
            anapanel(new Ayarlar());
        }

        private void btnkullanıcı_Click(object sender, EventArgs e)
        {
            btnmusteri.FillColor = Color.FromArgb(43, 122, 11);
            btnayarlar.FillColor = Color.FromArgb(125,206,19);
            anapanel(new Müsteri()) ;
        }
    }
}
