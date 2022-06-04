using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjP.Data;
using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;

namespace ProjPIV.Data
{
    public class DataContext : DbContext
    {

        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer(@"Server = .\\SQLEXPRESS;
                                         Database = WypozyczalniaRowerow; Trusted_Connection = True; ");

         }
        */

        public DataContext() : base("Server=.\\SQLExpress;Database=Northwind;Trusted_Connection=true;") { }

        public System.Data.Entity.DbSet<Rower> Rower { get; set; }
        public System.Data.Entity.DbSet<Wypożyczenie> Wypożyczenie { get; set; }
        public System.Data.Entity.DbSet<Klient> Klient { get; set; }
        public System.Data.Entity.DbSet<Faktura> Faktura { get; set; }
        public System.Data.Entity.DbSet<Pracownik> Pracownik { get; set; }

    }
}
