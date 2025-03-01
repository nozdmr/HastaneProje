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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            // Ad Soyad 
            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad From Tbl_Hastalar Where HastaTC = @p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString() + " " +dr[1].ToString();
            }
            bgl.Baglanti().Close();

            // Randevu Geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular WHERE HastaTC="+ tc, bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branşları Çekme

            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Branslar", bgl.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add (dr2[1].ToString());
            }
            bgl.Baglanti().Close();




        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {   
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar Where DoktorBrans= @p1", bgl.Baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.Baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular WHERE RandevuBrans = '"+ CmbBrans.Text + " '" +" AND RandevuDoktor= '" + CmbDoktor.Text + " ' And RandevuDurum=0 " , bgl.Baglanti() );
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.tcno = LblTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2" +
                " Where Randevuid=@p3", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Randevu Alınmıştır", "Bilgilendirme", MessageBoxButtons.OK);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
