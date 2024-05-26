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

        string sorguToplamOda = "select count(*) from Odalar";
        string sorguBosOda = "select count(*) from Odalar where Durum = 0";
        string sorguDoluOda = "select count(*) from Odalar where Durum = 1";
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

            using (SqlCommand komutBosOda = new SqlCommand(sorguBosOda, baglanti))
            {
                bosOda.Text = Convert.ToString(komutBosOda.ExecuteScalar());
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

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void oda101_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }
    }
}
