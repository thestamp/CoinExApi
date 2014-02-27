using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinexApi.Json
{
    public class TradePairsJson
    {
        public List<Trade_Pairs> trade_pairs { get; set; }
    }

    public class Trade_Pairs
    {
        public int id { get; set; }
        public float buy_fee { get; set; }
        public float sell_fee { get; set; }
        public long last_price { get; set; }
        public int currency_id { get; set; }
        public int market_id { get; set; }
        public string url_slug { get; set; }
        public long rate_min { get; set; }
        public long rate_max { get; set; }
        public long currency_volume { get; set; }
        public long market_volume { get; set; }
        public DateTime updated_at { get; set; }
    }

}
