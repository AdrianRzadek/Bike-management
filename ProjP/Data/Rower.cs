using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjP.Data
{
    public class Rower
    {

       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowerId { get; set; }
        [MaxLength(40)]
        public string Kolor { get; set; }

        [MaxLength(40)] public string RowerType { get; set; }
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
