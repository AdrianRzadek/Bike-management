using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjP.Data
{
    public class Wypożyczenie
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WypożyczenieId { get; set; }
        public DateTime DataWypożyczenia { get; set; }
        public DateTime DataOddania { get; set; }
       public float Cena { get; set; }
        //klucz obcy
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
