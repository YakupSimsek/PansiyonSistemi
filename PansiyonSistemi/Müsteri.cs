using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AMRConnector;
namespace PansiyonSistemi
{
    public partial class Müsteri : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YAKUP\\SQLEXPRESS;Initial Catalog=PansiyonSistemi;Integrated Security=True");
        DbConnector db;
        public Müsteri()
        {
            InitializeComponent();
            db = new DbConnector();
        }
        public void clear2()
        {
            txtad2.Clear();
            txtsoyad2.Clear();
            txtno2.Clear();
            txtadres2.Clear();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            bool kontrol;
            if (txtad.Text.Trim() == string.Empty || txtsoyad.Text.Trim() == string.Empty || txtsoyad.Text.Trim() == string.Empty || txtadres.Text.Trim() == string.Empty) 

                MessageBox.Show("alanları doldurun");
            else
            {
                kontrol = db.AddClient(txtad.Text.Trim(), txtsoyad.Text.Trim(), txtsoyad.Text.Trim(), txtadres.Text.Trim());
                if (kontrol)
                    clear2();
               
            }
        }

       
        private void pageara_Enter(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from MusteriTbl", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            txtara.Clear();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Musterino LIKE '%" + txtara.Text + "%'";
            dataGridView1.DataSource = bs.DataSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtno2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtadres2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void pagecıkart_Leave(object sender, EventArgs e)
        {
            clear2();
        }
    }
}
