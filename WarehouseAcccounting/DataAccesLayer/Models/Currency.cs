using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccesLayer.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(250)]
        public decimal CurrencyRate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
