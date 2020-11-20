using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccesLayer.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Address { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
