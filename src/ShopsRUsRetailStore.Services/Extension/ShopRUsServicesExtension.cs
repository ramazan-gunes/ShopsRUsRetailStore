using Microsoft.Extensions.DependencyInjection;
using ShopsRUsRetailStore.Data.Abstract;
using ShopsRUsRetailStore.Data.Concrete;
using ShopsRUsRetailStore.Services.Abstract;
using ShopsRUsRetailStore.Services.Concrete;

namespace ShopsRUsRetailStore.Services.Extension
{
    public static class ShopRUsServicesExtension
    {

        public static void AddShopRUsServices(this IServiceCollection services)
        {

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDiscountService, DiscountService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();

        }

    }
}
