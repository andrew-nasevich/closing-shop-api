using ClothingShopApi.Abstract.Models;
using ClothingShopApi.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClothingShopApi.Database
{
    public class ClothingShopDbContext : DbContext
    {
        private readonly AppSettings _settings;

        public ClothingShopDbContext(AppSettings settings)
        {
            _settings = settings;
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Clothing> Clothings { get; set; }
        public virtual DbSet<ClothingSize> ClothingSizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_settings.DbConnectionString);
        }
    }
}
