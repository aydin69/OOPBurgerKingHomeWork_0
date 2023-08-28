using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBurgerKingHomeWork_0.Models
{
    public abstract class BaseEntity
    {
        public string Isim { get; set; }
        public double Fiyat { get; set; }

        public short Adet { get; set; }

    }
}
