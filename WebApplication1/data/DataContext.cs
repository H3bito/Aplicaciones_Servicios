using Microsoft.EntityFrameworkCore;
using Practica1.sharet.entity;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace WebApplication1.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<investigador> investigadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<investigador>().HasIndex(c => c.firstName).IsUnique();
        }
    }
}