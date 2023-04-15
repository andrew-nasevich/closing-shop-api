using ClothingShopApi.Abstract.Interfaces;
using ClothingShopApi.Database.UnitOfWork.Repositories;

namespace ClothingShopApi.Database.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClothingShopDbContext _context;


        public IBrandRepository BrandRepository { get; init; }

        public ICategoryRepository CategoryRepository { get; init; }

        public IClothingRepository ClothingRepository { get; init; }


        public UnitOfWork(
            ClothingShopDbContext context,
            IBrandRepository brandRepository,
            ICategoryRepository categoryRepository,
            IClothingRepository clothingRepository)
        {
            _context = context;
            _context.Database.EnsureCreated();

            BrandRepository = brandRepository;
            CategoryRepository = categoryRepository;
            ClothingRepository = clothingRepository;
        }


        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
