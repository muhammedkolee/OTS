using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Otel_Takip_Sistemi
{
    public partial class Form5 : Form
    {
        string cinsiyet;
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection baglanti;
        string sorguFiyat = "select Fiyat from Odalar where Oda_No = '" + Odalar.oda + "'";
        public Form5()
        {
            InitializeComponent();
            baglanti = new SqlConnection(conString);
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            odaNo.Text = Odalar.oda;
            using (SqlCommand komutfiyat = new SqlCommand(sorguFiyat, baglanti))
            {
                fiyat.Text = Convert.ToString(komutfiyat.ExecuteScalar());
            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            RezervasyonKaydet();
        }

        public void RezervasyonKaydet()
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                SqlCommand komut = new SqlCommand("insert into Rezervasyon(OdaNo, Grup, MusteriTc, GirisTarih, CikisTarih) values(@odaNo, @Grup, @Tc, @Giris, @Cikis)", baglanti);
                komut.Parameters.AddWithValue("@odaNo", odaNo.Text);
                komut.Parameters.AddWithValue("@Grup", grup.Text);
                komut.Parameters.AddWithValue("@Tc", musteriTc.Text);
                komut.Parameters.AddWithValue("@Giris", girisTarih.Value);
                komut.Parameters.AddWithValue("@Cikis", cikisTarih.Value);
                komut.ExecuteNonQuery();
            }
        }
        private void Soyad_TextChanged(object sender, EventArgs e)
        {
            grup.Text = Ad.Text + " " + Soyad.Text;
        }

        private void tcNo_TextChanged(object sender, EventArgs e)
        {
            musteriTc.Text = tcNo.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void kadinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }

        private void tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
