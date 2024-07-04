using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbols cannot be over 10")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = "Company Name cannot be over 10")]
       public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1, 10000000000)]
        public decimal Purchase {get; set;}
        [Required]
        [Range(0.0001,100)]
        public decimal LastDiv {get; set;}
        [Required]
        [Range(0.0001,100)]
        public decimal Total {get; set;}
        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot be over 10")]
       public string Industry { get; set;} = string.Empty;
        [Required]
        [Range(1, 5000000000)]
       public long MarketCap { get; set;}
    }
}