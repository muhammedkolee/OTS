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
        int cinsiyet;
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
                SqlCommand komutRezervasyon = new SqlCommand("insert into Rezervasyon(OdaNo, Grup, MusteriTc, GirisTarih, CikisTarih) values(@odaNo, @Grup, @Tc, @Giris, @Cikis)", baglanti);
                komutRezervasyon.Parameters.AddWithValue("@odaNo", odaNo.Text);
                komutRezervasyon.Parameters.AddWithValue("@Grup", grup.Text);
                komutRezervasyon.Parameters.AddWithValue("@Tc", musteriTc.Text);
                komutRezervasyon.Parameters.AddWithValue("@Giris", girisTarih.Value);
                komutRezervasyon.Parameters.AddWithValue("@Cikis", cikisTarih.Value);
                komutRezervasyon.ExecuteNonQuery();

                SqlCommand komutOdalar = new SqlCommand("update Odalar set YetiskinSayisi = @YetiskinSayi, CocukSayisi = @CocukSayi, MüşteriTc = @MusteriTc, GirisTarih = @Giris, CikisTarih = @Cikis, RezervasyonDurum = 1 where Oda_No = @OdaNo", baglanti);
                komutOdalar.Parameters.AddWithValue("@OdaNo", odaNo.Text);
                komutOdalar.Parameters.AddWithValue("@YetiskinSayi", Convert.ToInt32(yetiskinSayi.Text));
                komutOdalar.Parameters.AddWithValue("@CocukSayi", Convert.ToInt32(CocukSayi.Text));
                komutOdalar.Parameters.AddWithValue("@MusteriTc", musteriTc.Text);
                komutOdalar.Parameters.AddWithValue("@Giris", girisTarih.Value);
                komutOdalar.Parameters.AddWithValue("@Cikis", cikisTarih.Value);
                komutOdalar.ExecuteNonQuery();

                SqlCommand komutMusteri = new SqlCommand("insert into Misafir(TcNo, Ad, Soyad, Uyruk, Cinsiyet, Yaş, Telefon, DogumTarih, Mail) values(@Tc, @Ad, @Soyad, @Uyruk, @Cinsiyet, @Yas, @Telefon, @Dogum, @Mail)", baglanti);
                komutMusteri.Parameters.AddWithValue("@Tc", tcNo.Text);
                komutMusteri.Parameters.AddWithValue("@Ad", Ad.Text);
                komutMusteri.Parameters.AddWithValue("@Soyad", Soyad.Text);
                komutMusteri.Parameters.AddWithValue("@Uyruk", uyruk.Text);
                komutMusteri.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                komutMusteri.Parameters.AddWithValue("@Yas", Convert.ToInt32(yas.Text));
                komutMusteri.Parameters.AddWithValue("@Telefon", Convert.ToString(telefon.Text));
                komutMusteri.Parameters.AddWithValue("@Dogum", dogum.Value);
                komutMusteri.Parameters.AddWithValue("@Mail", mail.Text);
                komutMusteri.ExecuteNonQuery();

                MessageBox.Show("Başarıyla Kaydedildi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cinsiyet = 0;
        }

        private void kadinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = 1;
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
