﻿using System;
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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcno;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = tcno;
            SqlCommand komut = new SqlCommand(" Select * From Tbl_Hastalar WHERE HastaTC= @p1 " , bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTelefon.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.Baglanti().Close();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand(" UPDATE Tbl_Hastalar SET HastaAd = @p1, HastaSoyad = @p2, HastaTelefon =@p3, HastaSifre= @p4, HastaCinsiyet=@p5 WHERE HastaTC=@p6 ", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
