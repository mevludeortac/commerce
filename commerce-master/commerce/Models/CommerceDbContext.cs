using System;
using commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace commerce.Models
{

    public class CommerceDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=localhost;Database=commerce;user='root';password='';Trusted_Connection=True");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
    }
}
