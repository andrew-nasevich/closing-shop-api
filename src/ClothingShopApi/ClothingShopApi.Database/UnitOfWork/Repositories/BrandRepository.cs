using ClothingShopApi.Abstract.Interfaces;
using ClothingShopApi.Abstract.Models;

namespace ClothingShopApi.Database.UnitOfWork.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ClothingShopDbContext _context;


        public BrandRepository(ClothingShopDbContext context) 
        {
            _context = context;
        }


        public void Add(Brand entity)
        {
            _context.Brands.Add(entity);
        }

        public Brand Get(int id)
        {
            return _context.Brands.FirstOrDefault(b => b.Id == id);
        }

        public Brand[] GetAll()
        {
            return _context.Brands.ToArray();
        }

        public void Remove(Brand entity)
        {
            _context.Brands.Remove(entity);
        }
    }
}
