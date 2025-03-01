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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular",bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           int secilen = dataGridView1.SelectedCells[0].RowIndex;
           string rndid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            FrmSekreterDetay fr = new FrmSekreterDetay();
            fr.randevuid = rndid;
            fr.Show();
        }
    }
}
