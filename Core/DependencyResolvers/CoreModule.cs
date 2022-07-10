using CoreLayer.CrossCuttingConcerns.Caching;
using CoreLayer.CrossCuttingConcerns.Caching.Microsoft;
using CoreLayer.CrossCuttingConcerns.Caching.Redis;
using CoreLayer.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CoreLayer.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            //serviceCollection.AddSingleton<ICacheManager, RedisCacheManager>();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
