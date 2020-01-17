using Microsoft.Extensions.Configuration;
using ThreeFourteen.QuickService;

namespace StockService
{
    public class Startup : ServiceStartup
    {
        public Startup(IConfiguration configuration) 
            : base(configuration)
        {
        }
    }
}
