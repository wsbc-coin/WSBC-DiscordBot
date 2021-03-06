﻿using System;

namespace WSBC.DiscordBot
{
    class CachingOptions
    {
        public TimeSpan DataCacheLifetime { get; set; } = TimeSpan.FromSeconds(10);
        public TimeSpan MiningPoolStatsDataCacheLifetime { get; set; } = TimeSpan.FromMinutes(3);
    }
}
