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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            MessageBox.Show("Kullanıcı başarıyla kaydedildi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            anaForm.Show();
        }
    }
}
