﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MainAliRezaMain.BackEnd
{
    public class ConnectingDB : DbContext
    {
        public DbSet<Person> person1 { get; set; }
        public DbSet<Product> product1 { get; set; }
        public DbSet<ProductGE> productGEs { get; set; }
        public DbSet<SaveShoppingCartToDB> saveShoppingCartToDBs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=mainStoreSite.mainalirezamain;Trusted_Connection=True;");
        }
    }
}
