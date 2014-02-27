using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinexApi.Json;

namespace CoinexApi.Models
{
    
    public class Currencies
    {
        public Currencies(CurrenciesJson jsonResponse)
        {
            Items = jsonResponse.currencies.Select(i => new CurrencyItem(i)).ToList();
        }
        public List<CurrencyItem> Items { get; set; }
    }

    public class CurrencyItem
    {
        public CurrencyItem(Currency item)
        {
            Id = item.id;
            Name = item.name;
            Description = item.desc;
            Fee = item.mining_fee;
            Confirmations = item.tx_conf;
            BlockConfirmations = item.blk_conf;
            PoolHashrate = item.hashrate;
            NetworkHashrate = item.net_hashrate;
            LastBlockTime = item.last_block_at;
            PoolMining = item.mining_enabled;
            MiningUrl = item.mining_url;
            Donations = item.donations;
            Algorithm = item.algo;
            Difficulty = item.diff;
            LastUpdated = item.updated_at;
            MiningScore = item.mining_score;
            MiningScoreMarket = item.mining_score_market;
            MiningScoreSkipSwitch = item.mining_skip_switch;
            _Virtual = item._virtual;
            MiningLastSwitched = item.switched_at;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float? Fee { get; set; }
        public int? Confirmations { get; set; }
        public int? BlockConfirmations { get; set; }
        public float? PoolHashrate { get; set; }
        public float? NetworkHashrate { get; set; }
        public DateTime? LastBlockTime { get; set; }
        public bool? PoolMining { get; set; }
        public string MiningUrl { get; set; }
        public float? MiningFee { get; set; }
        public string Donations { get; set; }
        public string Algorithm { get; set; }
        public float? Difficulty { get; set; }
        public DateTime LastUpdated { get; set; }
        public float? MiningScore { get; set; }
        public string MiningScoreMarket { get; set; }
        public bool MiningScoreSkipSwitch { get; set; }
        public bool _Virtual { get; set; }
        public DateTime? MiningLastSwitched { get; set; }
    }



}
