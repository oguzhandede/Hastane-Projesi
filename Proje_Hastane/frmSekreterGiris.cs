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
namespace Proje_Hastane
{
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Sekreter WHERE SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmSekreterDetay frs = new frmSekreterDetay();
                frs.Tcnumara = mskTc.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanliş Giriş Bilgileri");

            }
            bgl.baglanti().Close();

        }

        private void frmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
