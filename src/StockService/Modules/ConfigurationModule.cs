using Autofac;
using Microsoft.Extensions.Configuration;
using StockService.Configuration;

namespace StockService.Modules
{
    public class ConfigurationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c =>
                new FinnhubConfiguration
                {
                    ApiKey = c.Resolve<IConfiguration>().GetSection("FinnhubApiKey").Value
                })
                .As<IFinnhubConfiguration>()
                .SingleInstance();
        }
    }
}
