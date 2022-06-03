using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Wypożyczenie
    {
        public int IDwypożyczenia { get; set; }
        public DateTime DataWypożyczenia { get; set; }
        public DateTime DataOddania { get; set; }
        public Decimal Cena { get; set; }
    }
}
