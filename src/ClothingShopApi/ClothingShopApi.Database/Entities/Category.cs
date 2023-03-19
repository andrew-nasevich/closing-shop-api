using System.ComponentModel.DataAnnotations;

namespace ClothingShopApi.Database.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; } 
    }
}
