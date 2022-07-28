using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ShopsRUsRetailStore.Services.AutoMapper.Profiles;

namespace ShopsRUsRetailStore.Services.Extension
{
    public static class MappingExtension
    {
        public static void AddMapping(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DiscountProfile>();
                cfg.AddProfile<UserProfile>();
                cfg.AddProfile<InvoiceProfile>();
                cfg.AddProfile<OrderProfile>();
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

        }

    }
}
