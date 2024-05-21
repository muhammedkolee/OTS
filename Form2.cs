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
                SqlCommand komut = new SqlCommand("insert into Personel(Tc, Ad, Soyad, Telefon, Kullanıcı_Adı, Şifre) values(@TcNo, @Ad, @Soyad, @Telefon, @nick, @pass)", baglanti);
                komut.Parameters.AddWithValue("@TcNo", tcno.Text);
                komut.Parameters.AddWithValue("@Ad", name.Text);
                komut.Parameters.AddWithValue("@Soyad", surname.Text);
                komut.Parameters.AddWithValue("@Telefon", number.Text);
                komut.Parameters.AddWithValue("@nick", nickname.Text);
                komut.Parameters.AddWithValue("@pass", password.Text);
                komut.ExecuteNonQuery();

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
