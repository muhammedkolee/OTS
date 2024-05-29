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
    public partial class Kayit : Form
    {
        //SQL bağlantısında kullanılacak bağlantı dizisi.
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        public Kayit()
        {
            InitializeComponent();
        }

        //Butona tıklandığında müşteriyi kaydetmek için grekli olan SQL komutlarını çalıştıracak kod dizisi.
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
                komut.Parameters.AddWithValue("@Telefon", Convert.ToString(number.Text));
                komut.Parameters.AddWithValue("@nick", nickname.Text);
                komut.Parameters.AddWithValue("@pass", password.Text);
                komut.ExecuteNonQuery();
            }

            //Kayıt işlemi tamamlandıktan sonra kayıt formunu kapatıp giriş formuna yönlendiren kod dizisi.
            MessageBox.Show("Kullanıcı başarıyla kaydedildi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Giris anaForm = new Giris();
            this.Hide();
            anaForm.Show();
        }

        //TC kimlik numarası girerken yalnızca rakam girişini izin veren kod dizisi.
        private void tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}