namespace StockService.Configuration
{
    public interface IFinnhubConfiguration
    {
        string ApiKey { get; }
    }

    public class FinnhubConfiguration : IFinnhubConfiguration
    {
        public string ApiKey { get; set; }
    }
}
