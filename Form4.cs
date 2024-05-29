using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Otel_Takip_Sistemi
{
    public partial class Odalar : Form
    {
        //Formda kullanılacak değişkenler, SQL bağlantı dizeleri ve SQL sorgu komutları.
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        public static string oda;

        string sorguToplamOda = "select count(*) from Odalar";
        string sorguDoluOda = "select count(*) from Odalar where RezervasyonDurum = 1";
        string sorguTemizBosOda = "select count(*) from Odalar where RezervasyonDurum = 0 and Durum = 0";
        string sorguKirliBosOda = "select count(*) from Odalar where RezervasyonDurum = 0 and Durum = 1";
        string sorguYetiskin = "select sum(YetiskinSayisi) from Odalar";
        string sorguCocuk = "select sum(CocukSayisi) from Odalar";
        SqlConnection baglanti;
        
        public Odalar()
        {
            InitializeComponent();
            baglanti = new SqlConnection(conString);
        }
               
        //Form yüklenirken çalışacak fonksiyonlar.
        private void Form4_Load(object sender, EventArgs e)
        {
            OdaBilgi();
            Renk();
        }

        //Odalar hakkında kullanıcıya bilgi sağlamak için yapılmış fonksiyon.
        public void OdaBilgi()
        {
            baglanti.Open();
            using (SqlCommand komutToplamOda = new SqlCommand(sorguToplamOda, baglanti))
            {
                toplamOda.Text = Convert.ToString(komutToplamOda.ExecuteScalar());
            }

            using (SqlCommand komutTemizBosOda = new SqlCommand(sorguTemizBosOda, baglanti))
            {
                temizBosOda.Text = Convert.ToString(komutTemizBosOda.ExecuteScalar());
            }

            using (SqlCommand komutKirliBosOda = new SqlCommand(sorguKirliBosOda, baglanti))
            {
                kirliBosOda.Text = Convert.ToString(komutKirliBosOda.ExecuteScalar());
            }

            using (SqlCommand komutDoluOda = new SqlCommand(sorguDoluOda, baglanti))
            {
                doluOda.Text = Convert.ToString(komutDoluOda.ExecuteScalar());
            }

            int toplam;
            using (SqlCommand komutKisiSayisi = new SqlCommand(sorguYetiskin, baglanti))
            {
                toplam = Convert.ToInt32(Convert.ToString(komutKisiSayisi.ExecuteScalar()));
            }

            using (SqlCommand komutKisiSayisi2 = new SqlCommand(sorguCocuk, baglanti))
            {
                toplam += Convert.ToInt32(Convert.ToString(komutKisiSayisi2.ExecuteScalar()));
                toplamKisi.Text = Convert.ToString(toplam);
            }
            baglanti.Close();
        }

        //Butonların hangisine tıklandığını kaydeden ve bu veriyi farklı bir formda kullanılmak üzere taşıyan kod dizisi.
        public void Button_Click(object sender, EventArgs e)
        {
            oda = (sender as Button).Text.Substring(4);
            Form5 form5 = new Form5();
            form5.Show();
        }

        //Boş olan odalar için buton rengini kırmızı; dolu olan odalar için yeşil renk yapan fonksiyon.
        int renkDurum;
        public void Renk()
        {
            baglanti.Open();
            for (int i = 101; i < 411; i++)
            {
                if (i == 111 || i == 211 || i == 311)
                {
                    i += 90;
                }
                Button buton = this.Controls.Find("oda" + i.ToString(), true)[0] as Button;

                SqlCommand komutRenk = new SqlCommand("select RezervasyonDurum from Odalar where Oda_No = @odano", baglanti);
                komutRenk.Parameters.AddWithValue("@odano", i);
                renkDurum = Convert.ToInt32(komutRenk.ExecuteScalar());

                if (renkDurum == 0)
                {
                    buton.BackColor = Color.Red;
                }
                else
                {
                    buton.BackColor = Color.Green;
                }
            }
            baglanti.Close();
        }

        //Farklı bir formdayken yapılan değişiklikler anlık yansıtılamadığı için işbu forma yenilemek ve renkleri tekrarlamak için kullanılan buton.
        private void Yenile_Click(object sender, EventArgs e)
        {
            Renk();
        }
    }
}