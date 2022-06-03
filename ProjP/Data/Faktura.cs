using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Faktura
    {
        public int IDFaktura { get; set; }
        public char NIP { get; set; }
        public string Nazwa { get; set; }
        public DateTime DataWystawienia { get; set; }
    }
}
