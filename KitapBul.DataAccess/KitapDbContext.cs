using KitapBul.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitapBul.DataAccess
{
    public class KitapDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server= DESKTOP-03EK1L6\\SQLEXPRESS; Database=KitapDb;uid=sa;pwd=1234;");
        }
        public DbSet<Kitap> Kitaps { get; set; }
    }
}