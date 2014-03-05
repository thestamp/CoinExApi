using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinexApi.Json;

namespace CoinexApi.Models
{
    public class TradePairOrders
    {
        public TradePairOrders(TradePairOrdersJson jsonResponse)
        {
            Bids = jsonResponse.orders.Where(i => i.bid).Select(i => new TradePairOrder(i)).ToList();
            Asks = jsonResponse.orders.Where(i => !i.bid).Select(i => new TradePairOrder(i)).ToList();
        }

        public List<TradePairOrder> Bids { get; set; }
        public List<TradePairOrder> Asks { get; set; }
    }

    public class TradePairOrder
    {
        public TradePairOrder(Order order)
        {
            Id = order.id;
            UserId = order.user_id;
            TradePairId = order.trade_pair_id;
            Amount = (double)order.amount / 100000000;
            Filled = order.filled;
            Bid = order.bid;
            Rate = (double)order.rate / 100000000;
            CreatedTime = order.created_at;
            Complete = order.complete;
            Cancelled = order.cancelled;
            LastUpdated = order.updated_at;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int TradePairId { get; set; }
        public double Amount { get; set; }
        public long Filled { get; set; }
        public bool Bid { get; set; }
        public double Rate { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool Complete { get; set; }
        public bool Cancelled { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
