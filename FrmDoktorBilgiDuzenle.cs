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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTC=@p1",bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.Baglanti().Close();
            SqlCommand komut2 = new SqlCommand("Select BransAd From tbl_Branslar", bgl.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.Baglanti().Close();

        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar SET DoktorAd=@p1,DoktorSoyad=@p2" +
                ",DoktorBrans = @p3, DoktorSifre = @p4 Where DoktorTC=@p5", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Doktor Bilgisi Güncellendi");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
