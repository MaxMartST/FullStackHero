using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging.Abstractions;

namespace Infrastructure.Test.Caching;
public class LocalCacheService : CacheService<FullStackHero.Infrastructure.Caching.LocalCacheService>
{
    protected override FullStackHero.Infrastructure.Caching.LocalCacheService CreateCacheService() =>
        new(
            new MemoryCache(new MemoryCacheOptions()),
            NullLogger<FullStackHero.Infrastructure.Caching.LocalCacheService>.Instance);
}