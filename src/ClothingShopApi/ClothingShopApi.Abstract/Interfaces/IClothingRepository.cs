using ClothingShopApi.Abstract.Models;

namespace ClothingShopApi.Abstract.Interfaces
{
    public interface IClothingRepository: IRepository<Clothing>
    {
        ClothingSize[] GetClothingSizes(int id);
        Clothing[] GetClothingsByBrandId(int brandId);
        Clothing[] GetClothingsByCategoryId(int categoryId);
    }
}