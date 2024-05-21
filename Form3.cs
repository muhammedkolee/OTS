using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Takip_Sistemi
{
    public partial class Form3 : Form
    {
        public string conString = "Data Source=MUHAMMED\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //SqlConnection baglanti = new SqlConnection(conString);
            //baglanti.Open();

            //SqlDataAdapter adapter = new SqlDataAdapter("select * from Informations", baglanti);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dataGridView1.DataSource = dt;
        }
    }
}
