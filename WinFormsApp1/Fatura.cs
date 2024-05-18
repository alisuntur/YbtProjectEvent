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
    public partial class Fatura : Form
    {
        private SiparisSayfasi siparisSayfasi;

        public Fatura(SiparisSayfasi siparisSayfasi)
        {
            InitializeComponent();
            this.siparisSayfasi = siparisSayfasi;

            List<string> siparisListesi = siparisSayfasi.GetSiparisListesi();
            decimal toplamFiyat = siparisSayfasi.HesaplaToplamFiyat();
            foreach (string siparis in siparisListesi)
            {
                lstFatura.Items.Add(siparis);
            }
            lstFatura.Items.Add("---------------------------");
            lstFatura.Items.Add("Toplam Fiyat = " + toplamFiyat.ToString("C"));
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            AnaEkran anaEkranForm = new AnaEkran();
            anaEkranForm.Show();
            this.Hide();
        }
    }
}
