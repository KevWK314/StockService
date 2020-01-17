using Microsoft.AspNetCore.Mvc;
using StockService.Services;
using System.Threading.Tasks;

namespace StockService.Controllers
{
    [ApiController]
    [Route("api/stock")]
    public class StockController : ControllerBase
    {
        private readonly IStockPriceService _stockPriceService;

        public StockController(IStockPriceService stockPriceService)
        {
            _stockPriceService = stockPriceService;
        }

        [HttpGet]
        [Route("{symbol}")]
        public async Task<IActionResult> GetStockPrice(string symbol)
        {
            var price = await _stockPriceService.GetStockPrice(symbol);

            return Ok(price);
        }
    }
}
