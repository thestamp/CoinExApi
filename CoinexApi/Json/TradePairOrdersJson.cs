using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinexApi.Json
{
    public class TradePairOrdersJson
    {
        public List<Order> orders { get; set; }
    }

    public class Order
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int trade_pair_id { get; set; }
        public long amount { get; set; }
        public long filled { get; set; }
        public bool bid { get; set; }
        public long rate { get; set; }
        public DateTime created_at { get; set; }
        public bool complete { get; set; }
        public bool cancelled { get; set; }
        public DateTime updated_at { get; set; }
    }

}
