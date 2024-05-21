namespace Otel_Takip_Sistemi
{
    public partial class Form1 : Form
    {
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
    }
}
