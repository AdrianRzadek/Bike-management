using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Data
{
    public class Faktura
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FakturaId { get; set; }
        [MaxLength(10), MinLength(10)]
        public string NIP { get; set; }
        [MaxLength(40)]
        public string Nazwa { get; set; }
        public DateTime DataWystawienia { get; set; }




    }


 

    
    
}