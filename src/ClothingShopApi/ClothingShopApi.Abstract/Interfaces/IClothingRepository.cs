using ClothingShopApi.Abstract.Models;

namespace ClothingShopApi.Abstract.Interfaces
{
    public interface IClothingRepository: IRepository<Clothing>
    {
        ICollection<ClothingSize> GetClothingSizes(int id);
    }
}