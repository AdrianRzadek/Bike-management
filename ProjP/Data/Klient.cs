using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Klient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KlientId { get; set; }
        [MaxLength(11),MinLength(11)]
        public string Pesel { get; set; }
        [MaxLength(40)]
        public string Nazwisko { get; set; }
        [MaxLength(40)]
        public string Imię { get; set; }
        [MaxLength(24)]
        public string NrTelefon { get; set; }

        public Klient()
        {
            Wypożyczenia = new HashSet<Wypożyczenie>();

        }
        public virtual ICollection<Wypożyczenie> Wypożyczenia { get; set; }
    }
}
