using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CoinexApi.Json;
using CoinexApi.Models;
using Newtonsoft.Json;

namespace CoinexApi
{
    class WebApi
    {
        public static string Query(string url)
        {
            var request = WebRequest.Create(url);
            request.Proxy = WebRequest.DefaultWebProxy;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            if (request == null)
                throw new Exception("Non HTTP WebRequest");
            return new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd();
        }
    }

    public class MainApi
    {
        static public TradePairs GetTradePairs(Currencies currencies)
        {
            using (var w = new WebClient())
            {
                w.Headers.Add("User-Agent", "Mozilla/5.0");
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString("http://coinex.pw/api/v2/trade_pairs");
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return new TradePairs(!string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<TradePairsJson>(json_data) : new TradePairsJson(), currencies);
            }
        }

        public static Currencies GetCurrencies()
        {
            using (var w = new WebClient())
            {
                w.Headers.Add("User-Agent", "Mozilla/5.0");
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString("http://coinex.pw/api/v2/currencies");
                }
                catch (Exception e)
                {
                    throw new Exception("Unable to query coinex: " + e.Message);
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return new Currencies(!string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<CurrenciesJson>(json_data) : new CurrenciesJson());
            }
        }

        public static TradePairOrders GetOrders(TradePair pair)
        {
            using (var w = new WebClient())
            {
                w.Headers.Add("User-Agent", "Mozilla/5.0");
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString("https://coinex.pw/api/v2/orders?tradePair=" + pair.Id);
                }
                catch (Exception e)
                {
                    throw new Exception("Unable to query coinex: " + e.Message);
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return new TradePairOrders(!string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<TradePairOrdersJson>(json_data) : new TradePairOrdersJson());
            }
        }
    }
}
