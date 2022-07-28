using AspNetCoreRateLimit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ShopsRUsRetailStore.Core.Extensions.ServiceExtensions
{
    public static class RateLimitServiceExtension
    {
        public static IServiceCollection UseRateLimit(this IServiceCollection services, ConfigurationManager configurationManager)
        {

            services.AddOptions();
            services.AddMemoryCache();
            services.Configure<IpRateLimitOptions>(configurationManager.GetSection("IpRateLimiting"));
            services.Configure<IpRateLimitPolicies>(configurationManager.GetSection("IpRateLimitPolicies"));
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
            services.AddHttpContextAccessor();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
            //  app.UseIpRateLimiting();
            return services;
        }
    }
}
