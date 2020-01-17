using Autofac;
using StockService.Services;

namespace StockService.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StockPriceService>().As<IStockPriceService>().SingleInstance();
        }
    }
}
