using ClothingShopApi.Abstract.Models;

namespace ClothingShopApi.Abstract.Interfaces
{
    public interface IClothingRepository: IRepository<Clothing>
    {
        IEnumerable<ClothingSize> GetClothingSizes(int id);
    }
}