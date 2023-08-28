using OOPBurgerKingHomeWork_0.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOPBurgerKingHomeWork_0.Models
{
    public class Siparis : BaseEntity
    {
        public HamburgerMenu SecilenMenu { get; set; }
        public Boyut Buyukluk { get; set; }
        public List<EkMalzeme> Malzemeleri { get; set; }

        public Siparis()
        {
            Malzemeleri = new List<EkMalzeme>();
        }

        public void TutarHesapla()
        {
            Fiyat = SecilenMenu.Fiyat;

            switch(Buyukluk)
            {
                case Boyut.Buyuk:
                    Fiyat += 2;
                    break;
                case Boyut.Orta:
                    Fiyat += 1;
                    break;
            }

            foreach (EkMalzeme eleman in Malzemeleri)
            {
                Fiyat += eleman.Fiyat*eleman.Adet;
            }

            Fiyat *= Adet;
 
        }

        public override string ToString()
        {
            if (Malzemeleri.Count<1)
            {
                return $"{Isim} kişisine : {SecilenMenu.Isim} menüsü, x {Adet}, {Buyukluk} boy, Toplam : {Fiyat:C2}";
            }

           string malzemesi = null;

            foreach (EkMalzeme eleman in Malzemeleri)
            {
                malzemesi += $"{eleman.Isim} x {eleman.Adet},";
            }

            malzemesi = malzemesi.TrimEnd(',');

            return $"{Isim} kişisine : {SecilenMenu.Isim} menüsü, x {Adet}, {Buyukluk} boy, Ektstra soslar : {malzemesi}, Toplam : {Fiyat:C2}";
        }
    }
}
