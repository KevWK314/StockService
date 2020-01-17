using StockService.Configuration;
using System;
using System.Threading.Tasks;
using ThreeFourteen.Finnhub.Client;

namespace StockService.Services
{
    public interface IStockPriceService
    {
        Task<decimal> GetStockPrice(string symbol);
    }

    public class StockPriceService : IStockPriceService
    {
        private readonly FinnhubClient _client;

        public StockPriceService(IFinnhubConfiguration configuration)
        {
            _client = new FinnhubClient(configuration.ApiKey);
        }

        public async Task<decimal> GetStockPrice(string symbol)
        {
            var quote = await _client.Stock.GetQuote(symbol);
            return quote.Current;
        }
    }
}
