using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Otel_Takip_Sistemi
{
    public partial class Form5 : Form
    {
        //Formda kullanılan değişkenler ve SQL bağlantı komutları.
        int cinsiyet;
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection baglanti;
        string sorguFiyat = "select Fiyat from Odalar where Oda_No = '" + Odalar.oda + "'";

        public Form5()
        {
            InitializeComponent();
            baglanti = new SqlConnection(conString);
        }


        //Form yüklenirken yürütülen işlemler.
        private void Form5_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            odaNo.Text = Odalar.oda;

            using (SqlCommand komutfiyat = new SqlCommand(sorguFiyat, baglanti))
            {
                fiyat.Text = Convert.ToString(komutfiyat.ExecuteScalar());
            }
            ToplamFiyat();
        }


        //Kaydet butonuna basıldığında çalışacak fonksiyonlar ve komutlar dizisi.
        private void kaydet_Click(object sender, EventArgs e)
        {
            if (VeriKayitliMi(tcNo.Text))
            {
                MessageBox.Show("Veri Zaten Kayıtlı. Tekrar Deneyin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (tcNo.Text != "")
                {
                    MusteriKaydetTc();
                }

                else
                {
                    MusteriKaydetPs();
                }

                RezervasyonKaydet();
                this.Hide();
            }
        }


        //Kaydedilecek verinin kayıtlı olup olmadığını kontrol eden kod dizisi.
        private bool VeriKayitliMi(string veri)
        {
            using (SqlCommand komutVeri = new SqlCommand("select count(*) from Misafir where TcNo = @data", baglanti))
            {
                komutVeri.Parameters.AddWithValue("@data", veri);
                int deger = (int)komutVeri.ExecuteScalar();
                return deger > 0;
            }
        }


        //TC kimlik numarasına göre müşteri kaydetmek için gerekli olan SQL komutları.
        public void MusteriKaydetTc()
        {
            SqlCommand komutRezervasyon = new SqlCommand("insert into Rezervasyon(OdaNo, Grup, MusteriTc, GirisTarih, CikisTarih) values(@odaNo, @Grup, @Tc, @Giris, @Cikis)", baglanti);
            komutRezervasyon.Parameters.AddWithValue("@odaNo", odaNo.Text);
            komutRezervasyon.Parameters.AddWithValue("@Grup", grup.Text);
            komutRezervasyon.Parameters.AddWithValue("@Tc", musteriTc.Text);
            komutRezervasyon.Parameters.AddWithValue("@Giris", girisTarih.Value);
            komutRezervasyon.Parameters.AddWithValue("@Cikis", cikisTarih.Value);
            komutRezervasyon.ExecuteNonQuery();

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
        }


        //Pasaport numarasına göre müşteri kaydetmek için gerekli SQL komutları.
        public void MusteriKaydetPs()
        {
            SqlCommand komutRezervasyon = new SqlCommand("insert into Rezervasyon(OdaNo, Grup, MusteriPasaportNo, GirisTarih, CikisTarih) values(@odaNo, @Grup, @Pasaport, @Giris, @Cikis)", baglanti);
            komutRezervasyon.Parameters.AddWithValue("@odaNo", odaNo.Text);
            komutRezervasyon.Parameters.AddWithValue("@Grup", grup.Text);
            komutRezervasyon.Parameters.AddWithValue("@Pasaport", pasaportNo.Text);
            komutRezervasyon.Parameters.AddWithValue("@Giris", girisTarih.Value);
            komutRezervasyon.Parameters.AddWithValue("@Cikis", cikisTarih.Value);
            komutRezervasyon.ExecuteNonQuery();

            SqlCommand komutMusteri = new SqlCommand("insert into Misafir(PasaportNo, Ad, Soyad, Uyruk, Cinsiyet, Yaş, Telefon, DogumTarih, Mail) values(@Pasaport, @Ad, @Soyad, @Uyruk, @Cinsiyet, @Yas, @Telefon, @Dogum, @Mail)", baglanti);
            komutMusteri.Parameters.AddWithValue("@Pasaport", pasaportNo.Text);
            komutMusteri.Parameters.AddWithValue("@Ad", Ad.Text);
            komutMusteri.Parameters.AddWithValue("@Soyad", Soyad.Text);
            komutMusteri.Parameters.AddWithValue("@Uyruk", uyruk.Text);
            komutMusteri.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            komutMusteri.Parameters.AddWithValue("@Yas", Convert.ToInt32(yas.Text));
            komutMusteri.Parameters.AddWithValue("@Telefon", Convert.ToString(telefon.Text));
            komutMusteri.Parameters.AddWithValue("@Dogum", dogum.Value);
            komutMusteri.Parameters.AddWithValue("@Mail", mail.Text);
            komutMusteri.ExecuteNonQuery();
        }


        //Rezervasyon kaydetmek için gerekli SQL komutları.
        public void RezervasyonKaydet()
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                SqlCommand komutOdalar = new SqlCommand("update Odalar set YetiskinSayisi = @YetiskinSayi, CocukSayisi = @CocukSayi, MüşteriTc = @MusteriTc, GirisTarih = @Giris, CikisTarih = @Cikis, RezervasyonDurum = 1 where Oda_No = @OdaNo", baglanti);
                komutOdalar.Parameters.AddWithValue("@OdaNo", odaNo.Text);
                komutOdalar.Parameters.AddWithValue("@YetiskinSayi", Convert.ToInt32(yetiskinSayi.Text));
                komutOdalar.Parameters.AddWithValue("@CocukSayi", Convert.ToInt32(CocukSayi.Text));
                komutOdalar.Parameters.AddWithValue("@MusteriTc", musteriTc.Text);
                komutOdalar.Parameters.AddWithValue("@Giris", girisTarih.Value);
                komutOdalar.Parameters.AddWithValue("@Cikis", cikisTarih.Value);
                komutOdalar.ExecuteNonQuery();

                MessageBox.Show("Başarıyla Kaydedildi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Soyadı değiştiğinde Ad ve Soyad verilerini Gruba yazan kod dizisi.
        private void Soyad_TextChanged(object sender, EventArgs e)
        {
            grup.Text = Ad.Text + " " + Soyad.Text;
        }


        //Müşteri TC veya Pasaport numarası değiştiğinde bunu Rezervasyona otomatik aktaran ve diğer girişi engelleyen kod dizisi.
        private void tcNo_TextChanged(object sender, EventArgs e)
        {
            musteriTc.Text = tcNo.Text;
            pasaportNo.ReadOnly = true;
            if (tcNo.Text == "")
            {
                pasaportNo.ReadOnly = false;
            }
        }

        private void pasaportNo_TextChanged(object sender, EventArgs e)
        {
            pasaport.Text = pasaportNo.Text;
            tcNo.ReadOnly = true;
            if (pasaportNo.Text == "")
            {
                tcNo.ReadOnly = false;
            }
        }


        //Cinsiyet öğrenmek için kullanılan radiobutton komutları.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = 0;
        }

        private void kadinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = 1;
        }


        //TC kimlik, Pasaport numarası veya yaş bilgisi girerken yalnızca rakam girişine izin veren kod dizisi.
        private void tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void pasaportNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        //Fiyat türü değiştiğinde toplam fiyatın da türünü otomatik değiştiren kod dizisi.
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.Text;
        }


        //Gecelik fiyattan toplam fiyata çevrilmesi ve yazdırılması gereken kod dizisi.
        public void ToplamFiyat()
        {
            DateTime giris = girisTarih.Value;
            DateTime cikis = cikisTarih.Value;
            TimeSpan fark = cikis - giris;
            int gun = (int)fark.TotalDays + 1;
            FiyatToplam.Text = Convert.ToString(gun * (Convert.ToInt32(fiyat.Text)));
        }


        //Tarihler değiştiinde fiyat hesaplamasının tekrar yapılmasını sağlayan kod dizisi.
        private void cikisTarih_ValueChanged(object sender, EventArgs e)
        {
            ToplamFiyat();
        }
    }
}