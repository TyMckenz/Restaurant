using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Restaurant.Models
{
    public class RestaurantContext : DbContext
    {

        public DbSet<MenuItem> Menu { get; set; }
        public DbSet<Reservation> Reservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-90OJ2U4P\SQLEXPRESS;Database=Restaurant;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().HasMany(r => r.menuItems);
        }
    }
}

