using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemläxaEgenDatabas3
{
    internal class Homework3DBContext : DbContext
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DemoDatabas3;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
