using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjP.Data;
//using System.Data.Entity;
//using DbContext = System.Data.Entity.DbContext;

namespace ProjP
{
    public class DataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\SQLEXPRESS;
                                         Database = WypozyczalniaRowerow; Trusted_Connection = True; ");

        }


        //public DataContext() : base("Server=.\\SQLExpress;Database=WypozyczalniaRowerow;Trusted_Connection=true;") { }

        public DbSet<Rower> Rower { get; set; }
        public DbSet<Wypożyczenie> Wypożyczenie { get; set; }
        public DbSet<Klient> Klient { get; set; }
        public DbSet<Faktura> Faktura { get; set; }
        public DbSet<Pracownik> Pracownik { get; set; }

    }
}
