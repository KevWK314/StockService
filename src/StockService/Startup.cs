using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using ThreeFourteen.QuickService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StockService
{
    public class Startup : ServiceStartup
    {
        public Startup(IConfiguration configuration) 
            : base(configuration)
        {
        }

        public override void Configure(IApplicationBuilder app)
        {
            base.Configure(app);

            var serviceProvider = app.ApplicationServices;
            var env = serviceProvider.GetService<IWebHostEnvironment>();
            if (!env.IsDevelopment())
                app.UseHsts();
        }
    }
}
