using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsonEfCode.Model;

namespace HandsonEfCode.Context
{
    class MyContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1UI4VQI\SQLEXPRESS;Initial Catalog=PracticeDB;Integrated Security=True");
        }
    }
}
