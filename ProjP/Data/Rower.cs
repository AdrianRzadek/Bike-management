using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = System.Data.Entity.DbContext;

namespace ProjP.Data
{
    public class Rower
    {
      


        public int RowerId { get; set; }
        [MaxLength(40)]
        public string? Kolor { get; set; }

        [MaxLength(40)] public string? RowerType { get; set; }
        public float RozmiarRamy { get; set; }
        public float RozmiarOpon { get; set; }
        public int Biegi { get; set; }

        public Rower()
        {
            Wypożyczenia = new HashSet<Wypożyczenie>();

        }
        public virtual ICollection<Wypożyczenie> Wypożyczenia { get; set; }

    }
}
