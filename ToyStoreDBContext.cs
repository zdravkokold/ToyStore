using ToyStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ToyStore
{
    public class ToyStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("(localdb)\\mssqllocaldb");
        }
    }
}