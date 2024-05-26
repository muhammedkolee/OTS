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
    public partial class Form5 : Form
    {
        public string conString = "Data Source=DENIZ\\SQLEXPRESS;Initial Catalog=Giris;Integrated Security=True;Trust Server Certificate=True";
        
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            odaNo.Text = Odalar.oda;
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();   
        }
    }
}
