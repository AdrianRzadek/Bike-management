using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Rower
    {
        public int RowerId { get; set; }
        public string? Kolor { get; set; }
        public string? RowerType { get; set; }
        public float RozmiarRamy { get; set; }
        public float RozmiarOpon { get; set; }
        public int Biegi { get; set; }
        
    }
}
