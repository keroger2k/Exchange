using System.Text.RegularExpressions;
using Exchange.Core.Interfaces;

namespace Exchange.Cryptopia.Model
{
    public class CryptopiaCoin : ICurrencyCoin
    {
        private Regex _labelRegex = new Regex(@"(?<symbol>.*)\/(?<market>.*)");
        public string Exchange { get { return "Cryptopia"; } }
        public string Logo { get { return "https://www.cryptopia.co.nz/favicon.ico"; } }

        //GET https://www.cryptopia.co.nz/api/GetMarket/DOT_BTC
        public string URL { get { return "api/GetMarket/{0}"; } }
        public int TradePairId { get; set; }
        public string Label { get; set; }
        public double AskPrice { get; set; }
        public double BidPrice { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public double Volume { get; set; }
        public double LastPrice { get; set; }
        public double BuyVolume { get; set; }
        public double SellVolume { get; set; }
        public double Change { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double BaseVolume { get; set; }
        public double BaseBuyVolume { get; set; }
        public double BaseSellVolume { get; set; }

        public string TickerSymbol
        {
            get
            {
                return _labelRegex.Match(this.Label).Groups["symbol"].ToString();
            }
        }
        public string Market
        {
            get
            {
                return _labelRegex.Match(this.Label).Groups["market"].ToString();
            }
        }

        public double Price { get { return LastPrice; } }
    }
}