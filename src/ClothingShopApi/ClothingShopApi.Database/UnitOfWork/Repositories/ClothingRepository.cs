using ClothingShopApi.Abstract.Interfaces;
using ClothingShopApi.Abstract.Models;

namespace ClothingShopApi.Database.UnitOfWork.Repositories
{
    public class ClothingRepository : IClothingRepository
    {
        private readonly ClothingShopDbContext _context;


        public ClothingRepository(ClothingShopDbContext context)
        {
            _context = context;
        }


        public void Add(Clothing entity)
        {
            _context.Clothings.Add(entity);
        }

        public Clothing Get(int id)
        {
            return _context.Clothings.FirstOrDefault(c => c.Id == id);
        }

        public Clothing[] GetAll()
        {
            return _context.Clothings.ToArray();
        }

        public void Remove(Clothing entity)
        {
            _context.Clothings.Remove(entity);
        }

        public IEnumerable<ClothingSize> GetClothingSizes(int id)
        {
            return _context.ClothingSizes.Where(sc => sc.ClothingId == id).ToArray();
        }
    }
}
