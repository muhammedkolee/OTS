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

        //Butona týklandýðýnda kayýt olma formunu gösteren kod dizisi.
        private void register_Click(object sender, EventArgs e)
        {

            Kayit kayit = new Kayit();
            this.Hide();
            kayit.Show();
        }

        //Butona týklandýðýnda giriþ yapmayý saðlayan kod dizisi.
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
                GirisYardim.Show("Odalarla ilgili iþlem yapmak için\ngerekli menüye yönlendirir.", enter, new Point(enter.Location.X - 40, enter.Location.Y - (enter.Width + 40)), 2000);
                KayitYardim.Show("Kayýt olmak için gerekli menüye yönlendirir.", register, new Point(register.Location.X - 200, register.Location.Y - 250), 2000);
                SifreYardim.Show("Þifrenizi giriniz.", sifre, new Point(sifre.Location.X - 200, sifre.Location.Y - 160), 2000);
                AdYardim.Show("Kullanýcý adýnýzý giriniz.", nick, new Point(nick.Location.X - 50, nick.Location.Y - 130), 2000);
            }
        }
    }
}