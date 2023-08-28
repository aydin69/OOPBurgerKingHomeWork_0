using OOPBurgerKingHomeWork_0.Enums;
using OOPBurgerKingHomeWork_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBurgerKingHomeWork_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<HamburgerMenu> menuler = new List<HamburgerMenu>
            {
                new HamburgerMenu{Isim = "Teksas Burger", Fiyat=15, Bilgi="Gurme menusünden teksas lezzeti"},
                new HamburgerMenu{Isim ="Barberkü Burger", Fiyat=20, Bilgi="Barbekülü bir meksika ateşi"},
                new HamburgerMenu{Isim="Crispy Chicken", Fiyat=30, Bilgi="Tavuklarımız çok çıtır"},
                new HamburgerMenu{Isim="SteakHouse", Fiyat=25, Bilgi="Bu lezzeti mutlaka denemelisiniz"},
                new HamburgerMenu{Isim="TenderCips",Fiyat=22, Bilgi="Hem çıtır hem acı ağzınıza layık" }
            };

            List<EkMalzeme> ekMalzemeler = new List<EkMalzeme>
            {
                new EkMalzeme{Isim = "Ketçap", Fiyat=0.5},
                new EkMalzeme{Isim = "Mayonez", Fiyat=0.5},
                new EkMalzeme{Isim = "Hardal", Fiyat=0.5},
                new EkMalzeme{Isim = "Acı Sos", Fiyat=0.75},
                new EkMalzeme{Isim = "Barbekü", Fiyat=0.75},
                new EkMalzeme{Isim = "Ranch", Fiyat=0.75},
                new EkMalzeme{Isim = "Bufalo", Fiyat=1},
                new EkMalzeme{Isim = "Ballı Hardal", Fiyat=1},
                new EkMalzeme{Isim = "Sarımsaklı Mayonez", Fiyat=1}
            };

            cmbMenuler.DataSource = menuler;
            cmbMalzeme.DataSource = ekMalzemeler;
        }

        private void cmbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenuler.SelectedItem != null) lblBilgi.Text = (cmbMenuler.SelectedItem as HamburgerMenu).Bilgi;
            else lblBilgi.Text = "";
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIsim.Text.Trim()))
            {
                MessageBox.Show("lütfen bir isim giriniz");
                return;
            }

            Siparis s = new Siparis();
            s.Isim = txtIsim.Text;
            s.SecilenMenu = cmbMenuler.SelectedItem as HamburgerMenu;
            s.Adet = Convert.ToInt16(nmrAdet.Value);
            s.Malzemeleri = ekMalzemeler;

            if (rdbBuyuk.Checked) s.Buyukluk = Boyut.Buyuk;
            else if (rdbOrta.Checked) s.Buyukluk = Boyut.Orta;



            s.TutarHesapla();

            lstSiparisler.Items.Add(s);

           
        }

        List<EkMalzeme> ekMalzemeler = new List<EkMalzeme>();

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            EkMalzeme ekM = new EkMalzeme();
            ekM.Isim = (cmbMalzeme.SelectedItem as EkMalzeme).Isim;
            ekM.Fiyat = (cmbMalzeme.SelectedItem as EkMalzeme).Fiyat;
            ekM.Adet = Convert.ToInt16(nmrMalzeme.Value);
            lstMalzemeler.Items.Add($"{ekM} x{Convert.ToInt16(nmrMalzeme.Value)}");
            ekMalzemeler.Add(ekM);
        }

        private void btnMalzemeTemizle_Click(object sender, EventArgs e)
        {
            ekMalzemeler.Clear();
            lstMalzemeler.Items.Clear();
        }

        private void btnCiro_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (Siparis eleman in lstSiparisler.Items) total += eleman.Fiyat;

            MessageBox.Show(total.ToString());
        }

        private void cmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
