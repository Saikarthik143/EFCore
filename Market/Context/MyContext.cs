using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Market.Models;

namespace Market.Context
{
  public  class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1UI4VQI\SQLEXPRESS;Initial Catalog=EmsDB;Integrated Security=True");

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<item> Items { get; set; }
    }
}
