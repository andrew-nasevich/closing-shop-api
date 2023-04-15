using ClothingShopApi.Abstract.Interfaces;
using ClothingShopApi.Abstract.Models;

namespace ClothingShopApi.Database.UnitOfWork.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ClothingShopDbContext _context;


        public CategoryRepository(ClothingShopDbContext context)
        {
            _context = context;
        }


        public void Add(Category entity)
        {
            _context.Categories.Add(entity);
        }

        public Category Get(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public Category[] GetAll()
        {
            return _context.Categories.ToArray();
        }

        public void Remove(Category entity)
        {
            _context.Categories.Remove(entity);
        }
    }
}
