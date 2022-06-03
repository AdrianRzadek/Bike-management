using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPIV.Data
{
    public class DataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\SQLEXPRESS;
                                        Database = WypozyczalniaRowerow; Trusted_Connection = True; ");

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }
    }
}
