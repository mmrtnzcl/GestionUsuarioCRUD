using GestionUsuarioCRUD.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace GestionUsuarioCRUD
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(30);

                entity.Property(e => e.TipoEmpleado).IsRequired().HasColumnType("int(2)");
            });
        }

    }
}
