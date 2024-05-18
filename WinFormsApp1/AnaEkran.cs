using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }


        private void masa1_Click(object sender, EventArgs e)
        {
            OpenSiparisSayfasi("Masa1");

        }

        private void masa2_Click(object sender, EventArgs e)
        {
            OpenSiparisSayfasi("Masa2");

        }

        private void masa3_Click(object sender, EventArgs e)
        {
            OpenSiparisSayfasi("Masa 3");

        }

        private void masa4_Click(object sender, EventArgs e)
        {
            OpenSiparisSayfasi("Masa 4");
        }

        private void masa5_Click(object sender, EventArgs e)
        {
            OpenSiparisSayfasi("Masa 5");
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            OpenSiparisSayfasi("Masa 6 ");

        }

        private void OpenSiparisSayfasi(string masaAdi)
        {
            SiparisSayfasi siparisForm = new SiparisSayfasi(masaAdi);
            siparisForm.Show();
            this.Hide();
        }
    }
}
