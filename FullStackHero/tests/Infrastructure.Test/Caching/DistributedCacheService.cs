﻿using FullStackHero.Infrastructure.Common.Services;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;

namespace Infrastructure.Test.Caching;
public class DistributedCacheService : CacheService<FullStackHero.Infrastructure.Caching.DistributedCacheService>
{
    protected override FullStackHero.Infrastructure.Caching.DistributedCacheService CreateCacheService() =>
        new(
            new MemoryDistributedCache(Options.Create(new MemoryDistributedCacheOptions())),
            new NewtonSoftService(),
            NullLogger<FullStackHero.Infrastructure.Caching.DistributedCacheService>.Instance);
}