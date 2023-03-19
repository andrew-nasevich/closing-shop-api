using System.ComponentModel.DataAnnotations;

namespace ClothingShopApi.Abstract.Models
{
    public class ClothingSize
    {
        [Key]
        public int Id { get; set; }
        public int ClothingId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
