using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters.")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(50, ErrorMessage = "Company name cannot be over 50 characters.")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.1, 1000)]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Industry cannot be over 50 characters long.")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 100000000000000)]
        public long MarketCap { get; set; }
    }
}