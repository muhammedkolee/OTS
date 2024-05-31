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

namespace Otel_Takip_Sistemi
{
    public partial class DoluOda : Form
    {
        string conString = "Data Source=DESKTOP-8K93T2O\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection baglanti;

        string sorguTc = "select MusteriTc from Rezervasyon where OdaNo = " + Odalar.oda;
        string sorguGrup = "select Grup from Rezervasyon where OdaNo = " + Odalar.oda;
        string sorguGirisTarih = "select GirisTarih from Rezervasyon where OdaNo = " + Odalar.oda;
        string sorguCikisTarih = "select CikisTarih from Rezervasyon where OdaNo = " + Odalar.oda;
        string sorguYetiskinSayisi = "select YetiskinSayisi from Odalar where Oda_No = " + Odalar.oda;
        string sorguCocukSayisi = "select CocukSayisi from Odalar where Oda_No = " + Odalar.oda;
        string sorguFiyat = "select Fiyat from Odalar where Oda_No = " + Odalar.oda;

        private static string TcNu;

        public DoluOda()
        {
            InitializeComponent();
            baglanti = new SqlConnection(conString);
        }

        private void DoluOda_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            odaNo.Text = Odalar.oda;
            using (SqlCommand komutTcPs = new SqlCommand("select MusteriTc from Rezervasyon where OdaNo = " + Odalar.oda, baglanti))
            {
                if (Convert.ToString(komutTcPs.ExecuteScalar()) == "")
                {
                    SqlCommand komutPs = new SqlCommand("select MusteriPasaportNo from Rezervasyon where OdaNo = " + Odalar.oda, baglanti);
                    TcNu = Convert.ToString(komutPs.ExecuteScalar());
                    pasaportNo.Text = TcNu;
                    pasaport.Text = TcNu;
                    tcNo.ReadOnly = true;
                    VeriGetir();
                    VeriGetirPs();

                }
                else
                {
                    SqlCommand komutTc = new SqlCommand(sorguTc, baglanti);
                    TcNu = Convert.ToString(komutTc.ExecuteScalar());
                    musteriTc.Text = TcNu;
                    tcNo.Text = TcNu;
                    pasaportNo.ReadOnly = true;
                    VeriGetir();
                    VeriGetirTc();
                }
            }
            ToplamFiyat();
        }

        //dayım
        public void VeriGetir()
        {
            SqlCommand komutGrup = new SqlCommand(sorguGrup, baglanti);
            grup.Text = Convert.ToString(komutGrup.ExecuteScalar());

            SqlCommand komutGirisTarih = new SqlCommand(sorguGirisTarih, baglanti);
            girisTarih.Value = DateTime.Parse(Convert.ToString(komutGirisTarih.ExecuteScalar()));

            SqlCommand komutCikisTarih = new SqlCommand(sorguCikisTarih, baglanti);
            cikisTarih.Value = DateTime.Parse(Convert.ToString(komutCikisTarih.ExecuteScalar()));

            SqlCommand komutYetiskinSayisi = new SqlCommand(sorguYetiskinSayisi, baglanti);
            yetiskinSayi.Text = Convert.ToString(komutYetiskinSayisi.ExecuteScalar());

            SqlCommand komutCocukSayisi = new SqlCommand(sorguCocukSayisi, baglanti);
            CocukSayi.Text = Convert.ToString(komutCocukSayisi.ExecuteScalar());

            SqlCommand komutFiyat = new SqlCommand(sorguFiyat, baglanti);
            fiyat.Text = Convert.ToString(komutFiyat.ExecuteScalar());
        }


        public void VeriGetirTc()
        {
            using (SqlCommand komutAd = new SqlCommand("select Ad from Misafir where TcNo = " + TcNu, baglanti))
            {
                Ad.Text = Convert.ToString(komutAd.ExecuteScalar());
            }

            using (SqlCommand komutSoyad = new SqlCommand("select Soyad from Misafir where TcNo = " + TcNu, baglanti))
            {
                Soyad.Text = Convert.ToString(komutSoyad.ExecuteScalar());
            }

            using (SqlCommand komutUyruk = new SqlCommand("select Uyruk from Misafir where TcNo = " + TcNu, baglanti))
            {
                uyruk.Text = Convert.ToString(komutUyruk.ExecuteScalar());
            }

            using (SqlCommand komutCinsiyet = new SqlCommand("select Cinsiyet from Misafir where TcNo = " + TcNu, baglanti))
            {
                int cinsiyet = Convert.ToInt32(komutCinsiyet.ExecuteScalar());
                if (cinsiyet > 0)
                {
                    kadinRadioButton.Select();
                }
                else
                {
                    erkekRadioButton.Select();
                }
            }

            using (SqlCommand komutYas = new SqlCommand("select Yaş from Misafir where TcNo = " + TcNu, baglanti))
            {
                yas.Text = Convert.ToString(komutYas.ExecuteScalar());
            }

            using (SqlCommand komutTelefon = new SqlCommand("select Telefon from Misafir where TcNo = " + TcNu, baglanti))
            {
                telefon.Text = Convert.ToString(komutTelefon.ExecuteScalar());
            }

            using (SqlCommand komutDogumTarih = new SqlCommand("select DogumTarih from Misafir where TcNo = " + TcNu, baglanti))
            {
                dogum.Value = DateTime.Parse(Convert.ToString(komutDogumTarih.ExecuteScalar()));
            }

            using (SqlCommand komutMail = new SqlCommand("select Mail from Misafir where TcNo = " + TcNu, baglanti))
            {
                mail.Text = Convert.ToString(komutMail.ExecuteScalar());
            }
        }


        public void VeriGetirPs()
        {
            using (SqlCommand komutAd = new SqlCommand("select Ad from Misafir where PasaportNo = " + TcNu, baglanti))
            {
                Ad.Text = Convert.ToString(komutAd.ExecuteScalar());
            }

            using (SqlCommand komutSoyad = new SqlCommand("select Soyad from Misafir where PasaportNo = " + TcNu, baglanti))
            {
                Soyad.Text = Convert.ToString(komutSoyad.ExecuteScalar());
            }

            using (SqlCommand komutUyruk = new SqlCommand("select Uyruk from Misafir where PasaportNo = " + TcNu, baglanti))
            {
                uyruk.Text = Convert.ToString(komutUyruk.ExecuteScalar());
            }

            using (SqlCommand komutCinsiyet = new SqlCommand("select Cinsiyet from Misafir where PasaportNo = " + TcNu, baglanti))
            {
                int cinsiyet = Convert.ToInt32(komutCinsiyet.ExecuteScalar());
                if (cinsiyet > 0)
                {
                    kadinRadioButton.Select();
                }
                else
                {
                    erkekRadioButton.Select();
                }
            }

            using (SqlCommand komutYas = new SqlCommand("select Yaş from Misafir where PasaportNo = " + TcNu, baglanti))
            {
                yas.Text = Convert.ToString(komutYas.ExecuteScalar());
            }

            using (SqlCommand komutTelefon = new SqlCommand("select Telefon from Misafir where PasaportNo = " + TcNu, baglanti))
            {
                telefon.Text = Convert.ToString(komutTelefon.ExecuteScalar());
            }

            using (SqlCommand komutDogumTarih = new SqlCommand("select DogumTarih from Misafir where PasaportNo = " + TcNu, baglanti))
            {
                dogum.Value = DateTime.Parse(Convert.ToString(komutDogumTarih.ExecuteScalar()));
            }

            using (SqlCommand komutMail = new SqlCommand("select Mail from Misafir where PasaportNo = " + TcNu, baglanti))
            {
                mail.Text = Convert.ToString(komutMail.ExecuteScalar());
            }
        }

        public void ToplamFiyat()
        {
            DateTime giris = girisTarih.Value;
            DateTime cikis = cikisTarih.Value;
            TimeSpan fark = cikis - giris;
            int gun = (int)fark.TotalDays + 1;
            FiyatToplam.Text = Convert.ToString(gun * (Convert.ToInt32(fiyat.Text)));
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.Text;
        }

        private void pasaportNo_TextChanged(object sender, EventArgs e)
        {
            if (pasaportNo.Text == "")
            {
                tcNo.ReadOnly = false;
            }
            else
            {
                tcNo.ReadOnly = true;
            }
            pasaport.Text = pasaportNo.Text;
        }

        private void tcNo_TextChanged(object sender, EventArgs e)
        {
            if (tcNo.Text == "")
            {
                pasaportNo.ReadOnly = false;
            }
            else
            {
                pasaportNo.ReadOnly = true;
            }
            musteriTc.Text = tcNo.Text;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            grup.Text = string.Empty;
            tcNo.Text = string.Empty;
            pasaportNo.Text = string.Empty;
            Ad.Text = string.Empty;
            Soyad.Text = string.Empty;
            uyruk.Text = string.Empty;
            erkekRadioButton.Checked = false;
            kadinRadioButton.Checked = false;
            yas.Text = string.Empty;
            telefon.Text = string.Empty;
            dogum.Value = DateTime.Now;
            mail.Text = string.Empty;
            girisTarih.Value = DateTime.Now;
            cikisTarih.Value = DateTime.Now;
            yetiskinSayi.Text = "0";
            CocukSayi.Text = "0";
            ToplamFiyat();
        }

        public void Guncelle()
        {
            if (tcNo.Text == string.Empty && pasaportNo.Text == string.Empty)
            {
                SqlCommand sil = new SqlCommand("delete from Rezervasyon where OdaNo = " + Odalar.oda, baglanti);
                sil.ExecuteNonQuery();
                SqlCommand sifirla = new SqlCommand("update Odalar set RezervasyonDurum = @deger where Oda_No = " + Odalar.oda, baglanti);
                sifirla.Parameters.AddWithValue("@deger", false);
                sifirla.ExecuteNonQuery();
                SqlCommand guncelleYetiskin = new SqlCommand("update Odalar set YetiskinSayisi = 0, CocukSayisi = 0, Durum = 1, MüşteriTc = 0, RezervasyonDurum = @deger where Oda_No = " + Odalar.oda, baglanti);
                guncelleYetiskin.Parameters.AddWithValue("@deger", false);
                guncelleYetiskin.ExecuteNonQuery();

                MessageBox.Show("Kayıt tamamen silindi!", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tcNo.Text == string.Empty)
            {
                SqlCommand guncelleGrup = new SqlCommand("update Rezervasyon set Grup = @grup where OdaNo = " + Odalar.oda, baglanti);
                guncelleGrup.Parameters.AddWithValue("@grup", grup.Text);
                guncelleGrup.ExecuteNonQuery();

                SqlCommand guncellePasaport = new SqlCommand("update Rezervasyon set MusteriPasaportNo = @pasaport where OdaNo = " + Odalar.oda, baglanti);
                guncellePasaport.Parameters.AddWithValue("@pasaport", pasaportNo.Text);
                guncellePasaport.ExecuteNonQuery();

                SqlCommand guncelleYetiskin = new SqlCommand("update Odalar set YetiskinSayisi = 0, CocukSayisi = 0, Durum = 1, MüşteriTc = 0, RezervasyonDurum = @deger where Oda_No = " + Odalar.oda, baglanti);
                guncelleYetiskin.Parameters.AddWithValue("@deger", false);
                guncelleYetiskin.ExecuteNonQuery();                                       
            }
            else if (pasaportNo.Text == string.Empty)
            {
                SqlCommand guncelleGrup = new SqlCommand("update Rezervasyon set Grup = @grup where OdaNo = " + Odalar.oda, baglanti);
                guncelleGrup.Parameters.AddWithValue("@grup", grup.Text);
                guncelleGrup.ExecuteNonQuery();

                SqlCommand guncellePasaport = new SqlCommand("update Rezervasyon set TcNo = @tc where OdaNo = " + Odalar.oda, baglanti);
                guncellePasaport.Parameters.AddWithValue("@tc", tcNo.Text);
                guncellePasaport.ExecuteNonQuery();

                SqlCommand guncelleYetiskin = new SqlCommand("update YetiskinSayisi = 0, CocukSayisi = 0, Durum = 1, MüşteriTc = 0, RezervasyonDurum = 0 where Oda_No = " + Odalar.oda, baglanti);
                guncelleYetiskin.ExecuteNonQuery();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Guncelle();
            this.Hide();
        }
    }
}