using System.ComponentModel.DataAnnotations;

namespace DataAccesLayer.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
