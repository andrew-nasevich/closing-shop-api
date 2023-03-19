using System.ComponentModel.DataAnnotations;

namespace ClothingShopApi.Database.Entities
{
    public class Clothing
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        public ICollection<ClothingSize> ClothingSizes { get; set; }
    }
}
