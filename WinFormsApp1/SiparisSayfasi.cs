using System;
using System.Collections.Generic;
using System.Windows.Forms;
 

namespace WinFormsApp1
{
    public partial class SiparisSayfasi : Form
    {
        private string masaAdi;

        public class MenuItem
        {
            public string Isim { get; set; }
            public decimal Fiyat { get; set; }

            public MenuItem(string isim, decimal fiyat)
            {
                Isim = isim;
                Fiyat = fiyat;
            }
        }

        private List<MenuItem> CorbaCesitleri = new List<MenuItem>
        {
            new MenuItem("Ezogelin Çorbası", 45),
            new MenuItem("Mercimek Çorbası", 40),
            new MenuItem("Tavuk Suyu Çorbası", 50),
            new MenuItem("Sebze Çorbası", 35),
            new MenuItem("Balık Çorbası", 60)
        };

        private List<MenuItem> AnaYemekCesitleri = new List<MenuItem>
        {
            new MenuItem("Adana Kebabı", 120),
            new MenuItem("Fettuccine Alfredo", 110),
            new MenuItem("Izgara Somon", 150),
            new MenuItem("Biftek (Ribeye Steak)", 200),
            new MenuItem("Tavuk Şiş", 100)
        };

        private List<MenuItem> TatliCesitleri = new List<MenuItem>
        {
            new MenuItem("Baklava (2 dilim)", 45),
            new MenuItem("Tiramisu", 60),
            new MenuItem("Künefe", 70),
            new MenuItem("Çikolatalı Sufle", 55),
            new MenuItem("Cheesecake", 65)
        };

        private List<MenuItem> İcecekCesitleri = new List<MenuItem>
        {
            new MenuItem("Türk Kahvesi", 25),
            new MenuItem("Ayran", 15),
            new MenuItem("Kola", 20),
            new MenuItem("Limonata", 25),
            new MenuItem("Yeşil Çay", 20)
        };

        public SiparisSayfasi(string masa)
        {
            InitializeComponent();
            masaAdi = masa;
            lblMasa.Text = masaAdi;

            foreach (var corba in CorbaCesitleri)
            {
                lstUrunler.Items.Add(corba.Isim + " - " + corba.Fiyat.ToString("C"));
            }
            foreach (var anaYemek in AnaYemekCesitleri)
            {
                lstUrunler.Items.Add(anaYemek.Isim + " - " + anaYemek.Fiyat.ToString("C"));
            }
            foreach (var tatli in TatliCesitleri)
            {
                lstUrunler.Items.Add(tatli.Isim + " - " + tatli.Fiyat.ToString("C"));
            }
            foreach (var icecek in İcecekCesitleri)
            {
                lstUrunler.Items.Add(icecek.Isim + " - " + icecek.Fiyat.ToString("C"));
            }
        }
        private List<string> siparisListesi = new List<string>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string selectedItem = lstUrunler.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedItem))
            {
                lstSiparisler.Items.Add(selectedItem);
                siparisListesi.Add(selectedItem);

            }
        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            string selectedItem = lstSiparisler.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedItem))
            {
                lstSiparisler.Items.Remove(selectedItem);
                siparisListesi.Remove(selectedItem);

            }
        }
        public List<string> GetSiparisListesi()
        {
            return siparisListesi;
        }

        private void btn_faturaKes_Click(object sender, EventArgs e)
        {
            Fatura faturaForm = new Fatura(this);
            faturaForm.Show();
            this.Hide();
        }

        public decimal HesaplaToplamFiyat()
        {
            decimal toplamFiyat = 0;
            foreach (string siparis in siparisListesi)
            {
                string[] siparisParcalari = siparis.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                decimal fiyat = decimal.Parse(siparisParcalari[1].Trim(), System.Globalization.NumberStyles.Currency);
                toplamFiyat += fiyat;
            }
            return toplamFiyat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkranForm = new AnaEkran();
            anaEkranForm.Show();
            this.Hide();
        }
    }

}
