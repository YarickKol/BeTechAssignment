using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public decimal BaseCurrencyPrice { get; set; }

        public decimal Price { get; set; }

        public virtual int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory Category { get; set; }

        public virtual int CurrencyId { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual Currency Currency { get; set; }

        public string Barcode  { get; set; }

        public int Count { get; set; }
    }
}
