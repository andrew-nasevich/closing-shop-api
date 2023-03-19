namespace ClothingShopApi.Abstract.Interfaces
{
    public interface IUnitOfWork
    {
        IBrandRepository BrandRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IClothingRepository ClothingRepository { get; }

        void Complete();
    }
}
