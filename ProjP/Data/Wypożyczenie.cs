using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjP.Data
{
    public class Wypożyczenie
    {

     
        public int WypożyczenieId { get; set; }
        public DateTime DataWypożyczenia { get; set; }
        public DateTime DataOddania { get; set; }
        [Precision(18, 2)] public Decimal Cena { get; set; }
        public Faktura Faktura { get; set; }
        public Pracownik Pracownik { get; set; }

        public Wypożyczenie()
        {
            Rowery = new HashSet<Rower>();
            Klienci = new HashSet<Klient>();
        }

        public virtual ICollection<Rower> Rowery { get; set; }
        public virtual ICollection<Klient> Klienci { get; set; }

    }
}
