namespace WinFormsApp1
{
    public partial class girisSayfa : Form
    {
        public girisSayfa()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kAdi = txtKAdi.Text;
            string kPassword = txtPswd.Text;

            if (kAdi == "admin" && kPassword == "admin20")
            {
                AnaEkran anaEkranForm = new AnaEkran();
                anaEkranForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
