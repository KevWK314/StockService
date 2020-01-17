using System;
using System.Threading.Tasks;
using ThreeFourteen.QuickService;

namespace StockService
{
    class Program
    {
        public static Task Main(string[] args)
        {
            var service = new ServiceHost();
            return service.Run<Startup>(args);
        }
    }
}
