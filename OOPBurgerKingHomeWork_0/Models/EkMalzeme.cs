using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBurgerKingHomeWork_0.Models
{
    public class EkMalzeme : BaseEntity
    {
        public override string ToString()
        {
            return $"{Isim} => {Fiyat:C2}";
        }
    }
}
