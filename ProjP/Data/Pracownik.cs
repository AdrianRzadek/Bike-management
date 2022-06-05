using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Pracownik
    {
        public int PracownikId { get; set; }
        [MaxLength(11), MinLength(11)] public char Pesel { get; set; }
        [MaxLength(40)] public string NazwiskoPracownik { get; set; }
        [MaxLength(40)] public string ImięPracownik { get; set; }
        [MaxLength(40)] public string Stanowisko { get; set; }
        [MaxLength(24)] public char NrTelefonu { get; set; }
    }
}
