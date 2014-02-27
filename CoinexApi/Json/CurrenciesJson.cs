using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinexApi.Json
{
    public class CurrenciesJson
    {
        public List<Currency> currencies { get; set; }
    }

    
    public class Currency
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public float? tx_fee { get; set; }
        public int? tx_conf { get; set; }
        public int? blk_conf { get; set; }
        public float? hashrate { get; set; }
        public float? net_hashrate { get; set; }
        public DateTime? last_block_at { get; set; }
        public bool? mining_enabled { get; set; }
        public string mining_url { get; set; }
        public float? mining_fee { get; set; }
        public string donations { get; set; }
        public string algo { get; set; }
        public float? diff { get; set; }
        public DateTime updated_at { get; set; }
        public float? mining_score { get; set; }
        public string mining_score_market { get; set; }
        public bool mining_skip_switch { get; set; }
        public bool _virtual { get; set; }
        public DateTime? switched_at { get; set; }
    }



}
