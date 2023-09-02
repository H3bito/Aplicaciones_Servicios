using entrega1.shared.entitys;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace WebApplication1.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<investigador> proyectos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<proyecto>().HasIndex(c => c.name).IsUnique();

            modelBuilder.Entity<investigador>().HasIndex(c => c.firtname).IsUnique();
        }
    

    
    }
}