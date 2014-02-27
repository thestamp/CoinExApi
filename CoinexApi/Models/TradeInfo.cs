using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinexApi.Models
{
    public class TradeInfo
    {
        public TradePair Pair { get; set; }
        public Decimal Price { get; set; }
        public bool Buy { get; set; }
    }
}
