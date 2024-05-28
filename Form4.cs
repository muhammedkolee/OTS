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

namespace Otel_Takip_Sistemi
{
    public partial class Odalar : Form
    {
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        public static string oda;

        string sorguToplamOda = "select count(*) from Odalar";
        string sorguDoluOda = "select count(*) from Odalar where RezervasyonDurum = 1";
        string sorguTemizBosOda = "select count(*) from Odalar where RezervasyonDurum = 0 and Durum = 0";
        string sorguKirliBosOda = "select count(*) from Odalar where RezervasyonDurum = 0 and Durum = 1";
        string sorguYetiskin = "select sum(YetiskinSayisi) from Odalar";
        string sorguCocuk = "select sum(CocukSayisi) from Odalar";
        public Odalar()
        {
            InitializeComponent();
            baglanti = new SqlConnection(conString);
        }

        SqlConnection baglanti;

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
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            OdaBilgi();
        }

        public void Button_Click(object sender, EventArgs e)
        {
            oda = (sender as Button).Text.Substring(4);
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
