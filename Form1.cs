using System.Data.SqlClient;

namespace Otel_Takip_Sistemi
{
    public partial class Form1 : Form
    {
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {

            Form2 kayit = new Form2();
            this.Hide();
            kayit.Show();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            Form3 mainMenu = new Form3();
            this.Hide();
            mainMenu.Show();
        }
    }
}
