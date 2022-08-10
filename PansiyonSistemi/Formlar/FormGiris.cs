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
using System.Data.SqlClient;
using Guna;

namespace PansiyonSistemi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=YAKUP\\SQLEXPRESS;Initial Catalog=PansiyonSistemi;Integrated Security=True");
        private void picclose_MouseHover(object sender, EventArgs e)
        {
            ToolTip kapat = new ToolTip();
            kapat.SetToolTip(picclose,"Kapat");

        }

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtsifre.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtsifre.UseSystemPasswordChar = true;
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            grbgiris.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand giris = new SqlCommand("select * from KullanıcılarTbl where Kullanıcıadı=@p1 and Sifre=@p2", con);
                giris.Parameters.AddWithValue("@p1", txtad.Text);
                giris.Parameters.AddWithValue("@p2", txtsifre.Text);
                SqlDataAdapter sda = new SqlDataAdapter(giris);
                DataTable dt = new DataTable();
                sda.Fill(dt); if (dt.Rows.Count > 0)
                {
                    string rol = dt.Rows[0][3].ToString();
                    if (rol == "Personel")
                    {
                        Menuler fr = new Menuler();
                        fr.kullanıcı = txtad.Text;
                        txtad.Clear();
                        txtsifre.Clear();
                        fr.Show();
                        this.Hide();
                       


                    }
                    else if (rol == "Müdür")
                    {

                        Menuler fr = new Menuler();
                        fr.kullanıcı = txtad.Text;
                        txtad.Clear();
                        txtsifre.Clear();
                        fr.Show();
                        this.Hide();

                    }
                }
                else
                {
                   hata.Text = "Hatalı Kullanıcı adı veya şifre !!";
                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                con.Close();
            }
           

        }

       
    }
}
