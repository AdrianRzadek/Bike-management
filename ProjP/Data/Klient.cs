using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Klient
    {

     
        [Key]
        public char PeselKey { get; set; }
        public string Nazwisko { get; set; }
        public string Imię { get; set; }
        public char NrTelefon { get; set; }

       
    }
}
