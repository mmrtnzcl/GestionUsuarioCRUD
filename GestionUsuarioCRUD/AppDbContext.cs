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

        }
}
