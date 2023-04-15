using ClothingShopApi.Abstract.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothingShopApi.Database
{
    public static class ClothingShopDbSeeder
    {
        public static void SeedClothingData(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedBrands();
            modelBuilder.SeedCategories();
            modelBuilder.SeedClothings();
        }

        private static void SeedBrands(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(new Brand
            {
                Id = 1,
                Name = "Prada"
            });

            modelBuilder.Entity<Brand>().HasData(new Brand
            {
                Id = 2,
                Name = "Versace"
            });

            modelBuilder.Entity<Brand>().HasData(new Brand
            {
                Id = 3,
                Name = "Balenciaga"
            });

            modelBuilder.Entity<Brand>().HasData(new Brand
            {
                Id = 4,
                Name = "Dior"
            });
        }

        private static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Shoes"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                Name = "Pants"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                Name = "Coats"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 4,
                Name = "Bags"
            });
        }

        private static void SeedClothings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clothing>().HasData(new Clothing
            {
                Id = 1,
                BrandId = 1,
                CategoryId = 1,
                Name = "Just Prada!",
                Description = "Spectacular, amazing, non ever been done before",
                Price = 10000,
            });
        }
    }
}
