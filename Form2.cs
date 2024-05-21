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
using Microsoft.Data.SqlClient;

namespace Otel_Takip_Sistemi
{
    public partial class Form2 : Form
    {
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                SqlCommand komut1 = new SqlCommand("insert into Informations(TcNo, Ad, Soyad, Telefon) values(@TcNo, @Ad, @Soyad, @Telefon)", baglanti);
                komut1.Parameters.AddWithValue("@TcNo", tcno.Text);
                komut1.Parameters.AddWithValue("@Ad", name.Text);
                komut1.Parameters.AddWithValue("@Soyad", surname.Text);
                komut1.Parameters.AddWithValue("@Telefon", number.Text);
                komut1.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("insert into Info(Kullanıcı_Adı, Şifre) values(@nick, @password)", baglanti);
                komut2.Parameters.AddWithValue("@nick", nickname.Text);
                komut2.Parameters.AddWithValue("@password", password.Text);
                komut2.ExecuteNonQuery();
            }

            Form1 anaForm = new Form1();
            MessageBox.Show("Kullanıcı başarıyla kaydedildi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            anaForm.Show();
        }

        private void tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
