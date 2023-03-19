using System.ComponentModel.DataAnnotations;

namespace ClothingShopApi.Database.Entities
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Clothing> Clothings { get; set; }
    }
}
