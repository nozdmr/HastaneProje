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

namespace HastaneProje
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;
        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.tc = LblTC.Text;
            fr.Show();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            // Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorTC=@p1",bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.Baglanti().Close();

            // Doktorun Randevularını getirme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular WHERE RandevuDoktor = '" + LblAdSoyad.Text + " ' ", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
