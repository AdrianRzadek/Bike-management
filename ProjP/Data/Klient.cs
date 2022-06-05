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

        [Key,MaxLength(11),MinLength(11)]
        public char PeselKey { get; set; }
        [MaxLength(40)]
        public string Nazwisko { get; set; }
        [MaxLength(40)]
        public string Imię { get; set; }
        [MaxLength(24)]
        public char NrTelefon { get; set; }

        public Klient()
        {
            Wypożyczenia = new HashSet<Wypożyczenie>();

        }
        public virtual ICollection<Wypożyczenie> Wypożyczenia { get; set; }
    }
}
