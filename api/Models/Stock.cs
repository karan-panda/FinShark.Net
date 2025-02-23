using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        // This is to specify the precision and scale of the column 18 DIGITS and 2 DECIMALS

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Purchase { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}