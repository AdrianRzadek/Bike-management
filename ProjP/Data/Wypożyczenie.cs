using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = System.Data.Entity.DbContext;

namespace ProjP.Data
{
    public class Wypożyczenie
    {

        public Wypożyczenie()
        {
            Rowery = new HashSet<Rower>();
            Klienci = new HashSet<Klient>();
        }

  


        public int WypożyczenieId { get; set; }
        public DateTime DataWypożyczenia { get; set; }
        public DateTime DataOddania { get; set; }
        public Decimal Cena { get; set; }


        public virtual ICollection<Rower> Rowery { get; set; }
        public virtual ICollection<Klient> Klienci { get; set; }

    }
}
