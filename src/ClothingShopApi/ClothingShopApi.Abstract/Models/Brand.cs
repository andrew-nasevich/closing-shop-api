using System.ComponentModel.DataAnnotations;

namespace ClothingShopApi.Abstract.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Clothing> Clothings { get; set; }
    }
}
