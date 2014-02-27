using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinexApi.Json;

namespace CoinexApi.Models
{
    public class TradePairs
    {
        public TradePairs(TradePairsJson jsonResponse, Currencies currenciese)
        {
            Items = jsonResponse.trade_pairs.Select(i => new TradePair(i, currenciese)).ToList();
        }
        public List<TradePair> Items { get; set; }
    }

    public class TradePair
    {
        public TradePair(Trade_Pairs pair, Currencies currencies)
        {
            Id = pair.id;
            BuyFee = pair.buy_fee;
            SellFee = pair.sell_fee;
            LastPrice = pair.last_price;
            CurrencyId = pair.currency_id;
            MarketId = pair.market_id;
            UrlSlug = pair.url_slug;
            RateMin = pair.rate_min;
            RateMax = pair.rate_max;
            CurrencyVolume = pair.currency_volume;
            MarketVolume = pair.market_volume;
            LastUpdated = pair.updated_at;

            var pairs = UrlSlug.Split('_');
            FirstCurrencyItem = currencies.Items.First(i => String.Equals(i.Name, pairs[1], StringComparison.CurrentCultureIgnoreCase));
            SecondCurrencyItem = currencies.Items.First(i => String.Equals(i.Name, pairs[0], StringComparison.CurrentCultureIgnoreCase));
        }

        public CurrencyItem FirstCurrencyItem { get; set; }
        public CurrencyItem SecondCurrencyItem { get; set; }
        public int Id { get; set; }
        public float BuyFee { get; set; }
        public float SellFee { get; set; }
        public long LastPrice { get; set; }
        public int CurrencyId { get; set; }
        public int MarketId { get; set; }
        public string UrlSlug { get; set; }
        public long RateMin { get; set; }
        public long RateMax { get; set; }
        public long CurrencyVolume { get; set; }
        public long MarketVolume { get; set; }
        public DateTime LastUpdated { get; set; }
    }

}
