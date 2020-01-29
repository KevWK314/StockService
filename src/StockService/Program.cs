using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ThreeFourteen.QuickService;

namespace StockService
{
    class Program
    {
        public static Task Main(string[] args)
        {
            var service = new ServiceHost();
            return service.Run<Startup>(args, new ConfigureHost());
        }
    }

    public class ConfigureHost : IConfigureHost
    {
        public void Configure(IHostBuilder hostBuilder)
        {
        }

        public void Configure(IWebHostBuilder webHostBuilder)
        {
            webHostBuilder.UseUrls();
        }
    }
}
