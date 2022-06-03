using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Pracownik
    {
        public int IdPracownik { get; set; }
        public char Pesel { get; set; }
        public string NazwiskoPracownik { get; set; }
        public string ImięPracownik { get; set; }
        public string Stanowisko { get; set; }
        public char NrTelefonu { get; set; }
    }
}
