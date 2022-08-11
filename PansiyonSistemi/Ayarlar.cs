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
namespace PansiyonSistemi
{
    public partial class Ayarlar : Form
    {
        DbConnector db;
        SqlConnection con = new SqlConnection("Data Source=YAKUP\\SQLEXPRESS;Initial Catalog=PansiyonSistemi;Integrated Security=True");
        public Ayarlar()
        {
            InitializeComponent();
            db = new DbConnector();
        }
        public void clear()
        {
            txtad.Clear();
            txtsifre.Clear();
            tabControl1.SelectedTab = pageekle;
        }
        private void clear1()
        {

            txtad2.Clear();
            txtsifre2.Clear();
            
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void pageekle_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void pakeara_Enter(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from KullanıcılarTbl where Rolü = 'Personel'", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            txtara.Clear();
        }

        private void pageara_Leave(object sender, EventArgs e)
        {
            txtara.Clear();
        }

        private void pagesil_Leave(object sender, EventArgs e)
        {
            clear1();
        }

        private void btngosterge_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komutekle = new SqlCommand("insert into KullanıcılarTbl (Kullanıcıadı,Sifre,Rolü) values (@p1,@p2,@p3)", con);
            komutekle.Parameters.AddWithValue("@p1", txtad.Text);
            komutekle.Parameters.AddWithValue("@p2",txtsifre.Text);
            komutekle.Parameters.AddWithValue("@p3", txtrol.Text);
            komutekle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel Kaydı Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsıl_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sil = new SqlCommand("delete from KullanıcılarTbl where Kullanıcıadı =@p1 ",con);
            sil.Parameters.AddWithValue("@p1",txtad2.Text);
            sil.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel Kaydı Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngun_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand guncelle = new SqlCommand("update set KullanıcılarTbl Kullanıcıadı=@p1,Sifre=@p2",con);
            guncelle.Parameters.AddWithValue("@p1",txtad2.Text);
            guncelle.Parameters.AddWithValue("@p2",txtsifre2.Text);
            guncelle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel Kaydı Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Kullanıcıadı LIKE '%" + txtara.Text + "%'";
            dataGridView1.DataSource = bs.DataSource;    
        }
    }
}
