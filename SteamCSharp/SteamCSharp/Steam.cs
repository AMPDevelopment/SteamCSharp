using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteamCSharp.Entities.Community;
using SteamCSharp.Entities.Community.Statistics;

namespace SteamCSharp
{
    public sealed class Steam
    {
        // Base
        private const string BaseUrl = "https://api.steampowered.com/";

        // Interfaces
        private const string PlayerService = "IPlayerService";

        private const string SteamUserUrl = "ISteamUser";
        private const string SteamUserStatsUrl = "ISteamUserStats";

        // Methods
        private const string GetPlayerSummariesUrl = "GetPlayerSummaries";

        private const string ResolveVanityUrl = "ResolveVanityURL";
        private const string GetOwnedGamesUrl = "GetOwnedGames";
        private const string GetFriendListUrl = "GetFriendList";
        private const string GetUserStatsForGameUrl = "GetUserStatsForGame";
        private const string GetPlayerBansUrl = "GetPlayerBans";

        // Version
        private const string ApiVersion1Url = "v0001";

        private const string ApiVersion2Url = "v0002";

        // Parameter
        private const string KeyParameter = "?key=";

        private const string AppIdParameter = "&appid=";
        private const string VanityUrlParameter = "&vanityurl=";
        private const string SteamIdParameter = "&steamid=";
        private const string SteamIdsParameter = "&steamids=";
        private const string RelationshipParameter = "&relationship=";

        public Steam(string key)
        {
            Key = key;
        }

        private static string Key { get; set; }

        public async Task<SteamUser> GetSteamUserAsync(string steamId)
        {
            var result = ulong.TryParse(steamId, out var steamUserId);

            if (!result)
            {
                var vanityUrl = await ResolveVanityUrlAsync(steamId);
                if (vanityUrl.Success == 1)
                {
                    steamUserId = vanityUrl.SteamId;
                }
            }

            var parameters = $"{SteamIdsParameter}{steamUserId}";
            var request = await GetAsync(SteamUserUrl, GetPlayerSummariesUrl, ApiVersion2Url, parameters);
            return JsonConvert.DeserializeObject<SteamUserResponse>(request).Result.Players.First();
        }

        public async Task<SteamVanity> ResolveVanityUrlAsync(string vanity)
        {
            var parameters = $"{VanityUrlParameter}{vanity}";
            var request = await GetAsync(SteamUserUrl, ResolveVanityUrl, ApiVersion1Url, parameters);
            return JsonConvert.DeserializeObject<VanityUserResponse>(request).Result;
        }

        public async Task<SteamPlayerStatsForGameResult> GetSteamPlayerStatsForGameAsync(int appId, ulong steamId)
        {
            var parameters = $"{AppIdParameter}{appId}{SteamIdParameter}{steamId}";
            var request = await GetAsync(SteamUserStatsUrl, GetUserStatsForGameUrl, ApiVersion2Url, parameters);
            return JsonConvert.DeserializeObject<SteamPlayerStatsForGameResultResponse>(request).Result;
        }

        public async Task<SteamPlayerOwnedGamesResult> GetSteamPlayerOwnedGamesAsync(ulong steamId)
        {
            var parameters = $"{SteamIdParameter}{steamId}";
            var request = await GetAsync(PlayerService, GetOwnedGamesUrl, ApiVersion1Url, parameters);
            return JsonConvert.DeserializeObject<SteamPlayerOwnedGamesResultResponse>(request).Result;
        }

        public async Task<SteamPlayerBan> GetSteamPlayerBansAsync(ulong steamId)
        {
            var parameters = $"{SteamIdsParameter}{steamId}";
            var request = await GetAsync(SteamUserUrl, GetPlayerBansUrl, ApiVersion1Url, parameters);
            return JsonConvert.DeserializeObject<SteamPlayerBansContainer>(request).SteamPlayerBans.First();
        }

        private static async Task<string> GetAsync(string interfaceName, string methodName, string methodVersion, string parameters)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var message = await client.GetAsync($"{BaseUrl}/{interfaceName}/{methodName}/{methodVersion}/{KeyParameter}{Key}{parameters}");
                if (message.StatusCode == HttpStatusCode.OK) return await message.Content.ReadAsStringAsync();
                throw new SteamException(await message.Content.ReadAsStringAsync());
            }
        }

        private class SteamException : Exception
        {
            public SteamException(string message) : base(message)
            {
            }
        }
    }
}
