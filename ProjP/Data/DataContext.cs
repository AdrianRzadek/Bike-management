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
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


      
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

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klient>().HasData(GetKlienci());
            base.OnModelCreating(modelBuilder);
        }

        private Klient[] GetKlienci()
        {
            return new Klient[]
            {
                /*
                new Klient { PeselKey = 12332112331, Nazwisko = "Tshirt", Imię = "Red", NrTelefon = 123321123},
                new Klient { PeselKey = 2, Name = "Tshirt", Description = "Blue Color", Price = 10.99},
                new Klient { PeselKey = 3, Name = "Shirt", Description = "Formal Shirt", Price = 10.99},
                new Klient { PeselKey = 4, Name = "Socks", Description = "Yellow ", Price = 2},
            */
                };
        }

    }
}
