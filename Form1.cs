using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Otel_Takip_Sistemi
{
    public partial class Giris : Form
    {
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        public Giris()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {

            Kayit kayit = new Kayit();
            this.Hide();
            kayit.Show();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            Odalar mainMenu = new Odalar();
            this.Hide();
            mainMenu.Show();
        }


    }
}
