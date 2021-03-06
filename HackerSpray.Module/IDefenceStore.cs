﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HackerSpray.Module
{
    public interface IDefenceStore
    {
        Task<HitStats> IncrementHit(string key, IPAddress origin);
        Task<HitStats> IncrementHit(string key, IPAddress origin, TimeSpan keyInterval);
        Task<int> GetHitsForKey(string key);
        Task<int> GetHitsFromOrigin(IPAddress origin);
        Task<bool> WhitelistKey(string key);
        Task<bool> BlacklistKey(string key, TimeSpan expiry);
        Task<string[]> GetKeyBlacklists(string key);
        Task<string[]> GetOriginBlacklists(IPAddress origin);
        Task<bool> WhitelistOrigin(IPAddress origin);
        Task<bool> BlacklistOrigin(IPAddress origin, TimeSpan expiry);
        Task<bool> BlacklistOrigin(IPAddress start, IPAddress end);
        Task<bool> IsKeyBlacklisted(string key);
        Task<bool> IsOriginBlacklisted(IPAddress origin);
    }
}
