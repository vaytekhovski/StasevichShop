using Microsoft.EntityFrameworkCore;
using Shop.Models.DataBase;

namespace Shop.Services.DataBase
{
    public class ShopContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Orders> Orders { get; set; }


        public ShopContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ShopDB;Trusted_Connection=True;");
        }

    }
}
