using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        // Here only include the properties that you want to expose to the client
        // Thus we do not include the Id property as we do not want the client to set the Id

        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        // This is to specify the precision and scale of the column 18 DIGITS and 2 DECIMALS

        public decimal Purchase { get; set; }

        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
    }
}