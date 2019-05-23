using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MainAliReza.BackEnd
{
    public class ConnectingDB : DbContext
    {
        public DbSet<Person> person1 { get; set; }
        public DbSet<Product> product1 { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb ; Integrated Security = true; AttachDbFileName=E:\project972dis\alirezadis\MainAliReza\MainAliReza\BackEnd\mainStoreSite.mainalireza.mdf;Database=mainStoreSite.mainalireza;Trusted_Connection=True;");
        }
    }
}
