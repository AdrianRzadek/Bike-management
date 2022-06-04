using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Klient
    {

        public Klient()
        {
            Wypożyczenia = new HashSet<Wypożyczenie>();
        }

        public char PeselID { get; set; }
        public string Nazwisko { get; set; }
        public string Imię { get; set; }
        public char NrTelefon { get; set; }

        public virtual ICollection<Wypożyczenie> Wypożyczenia { get; set; } 
    }
}
