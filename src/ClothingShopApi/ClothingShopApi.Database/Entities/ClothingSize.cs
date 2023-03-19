using System.ComponentModel.DataAnnotations;

namespace ClothingShopApi.Database.Entities
{
    public class ClothingSize
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
