using ClothingShopApi.Abstract.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothingShopApi.Database
{
    public class ClothingShopDbContext : DbContext
    {
        private readonly AppSettings _settings;


        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Clothing> Clothings { get; set; }
        public virtual DbSet<ClothingSize> ClothingSizes { get; set; }


        public ClothingShopDbContext(AppSettings settings)
        {
            _settings = settings;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(_settings.DbName);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedClothingData();
        }
    }
}
