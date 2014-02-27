using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinexApi.Models;

namespace CoinexApi.Handlers
{
    internal class PairCurrencyMapHandler
    {
        private readonly Currencies _currencies;

        internal PairCurrencyMapHandler(Currencies currencies)
        {
            _currencies = currencies;
        }

        internal TradePair MapPair(TradePair pair)
        {

            var pairs = pair.UrlSlug.Split('_');
            _currencies.Items.First(i => String.Equals(i.Name, pairs[0], StringComparison.CurrentCultureIgnoreCase));
            return pair;
        }
    }
}
