using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Otel_Takip_Sistemi
{
    public partial class Giris : Form
    {
        public string conString = "Data Source=DESKTOP-8K93T2O\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection baglanti;
        public Giris()
        {
            InitializeComponent();
             baglanti = new SqlConnection(conString);
        }

        //Butona t�kland���nda kay�t olma formunu g�steren kod dizisi.
        private void register_Click(object sender, EventArgs e)
        {

            Kayit kayit = new Kayit();
            this.Hide();
            kayit.Show();
        }

        //Butona t�kland���nda giri� yapmay� sa�layan kod dizisi.
        private void enter_Click(object sender, EventArgs e)
        {
            Odalar mainMenu = new Odalar();
            this.Hide();
            mainMenu.Show();

        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                GirisYardim.Show("Odalarla ilgili i�lem yapmak i�in\ngerekli men�ye y�nlendirir.", enter, new Point(enter.Location.X - 40, enter.Location.Y - (enter.Width + 40)), 2000);
                KayitYardim.Show("Kay�t olmak i�in gerekli men�ye y�nlendirir.", register, new Point(register.Location.X - 200, register.Location.Y - 250), 2000);
                SifreYardim.Show("�ifrenizi giriniz.", sifre, new Point(sifre.Location.X - 200, sifre.Location.Y - 160), 2000);
                AdYardim.Show("Kullan�c� ad�n�z� giriniz.", nick, new Point(nick.Location.X - 50, nick.Location.Y - 130), 2000);
            }
        }
    }
}