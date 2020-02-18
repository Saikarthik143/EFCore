using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsonEFCodeFA.Models;
namespace HandsonEFCodeFA.Context
{
    class StudentContext:DbContext
    {
        //define entities
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1UI4VQI\SQLEXPRESS;Initial Catalog=PracticeDB;Integrated Security=True");
        }
    }
}
