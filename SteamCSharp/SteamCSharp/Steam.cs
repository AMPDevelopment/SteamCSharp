using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteamCSharp.Entities.Community;
using SteamCSharp.Entities.Community.Statistics;
using SteamCSharp.Entities.Community.Statistics.Game;
using SteamCSharp.Entities.Community.Statistics.User;

namespace SteamCSharp
{
    public sealed class Steam
    {
        // Base
        private const string BaseUrl = "https://api.steampowered.com/";

        // Interfaces
        private const string PlayerService = "IPlayerService";

        private const string SteamNewsUrl = "ISteamNews";
        private const string SteamUserUrl = "ISteamUser";
        private const string SteamUserStatsUrl = "ISteamUserStats";

        // Methods
        // Methods - ISteamUser
        private const string GetPlayerSummariesUrl = "GetPlayerSummaries";

        // Todo
        private const string GetFriendListUrl = "GetFriendList";

        // Methods - ISteamUserStats
        private const string GetPlayerAchievements = "GetPlayerAchievements";

        private const string GetOwnedGamesUrl = "GetOwnedGames";
        private const string GetUserStatsForGameUrl = "GetUserStatsForGame";
        private const string GetPlayerBansUrl = "GetPlayerBans";
        private const string ResolveVanityUrl = "ResolveVanityURL";
        private const string GetSchemaForGame = "GetSchemaForGame";
        
        // Todo
        private const string GetGlobalAchievementPercentagesForApp = "GetGlobalAchievementPercentagesForApp";
        private const string GetNumberOfCurrentPlayers = "GetNumberOfCurrentPlayers";

        // Version
        private const string Version1 = "v1";
        private const string Version2 = "v2";

        // Parameter
        private const string KeyParameter = "?key=";
        private const string AppIdParameter = "&appid=";
        private const string VanityUrlParameter = "&vanityurl=";
        private const string SteamIdParameter = "&steamid=";
        private const string SteamIdsParameter = "&steamids=";
        private const string RelationshipParameter = "&relationship=";

        public Steam(string userKey)
        {
            UserKey = userKey;
        }

        private static string UserKey { get; set; }

        #region ISteamUser

        /// <summary>
        /// Gets the steam user.
        /// </summary>
        /// <param name="steamId">Steam ID 64 or vanity username</param>
        /// <returns></returns>
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
            var request = await GetAsync(SteamUserUrl, GetPlayerSummariesUrl, Version2, parameters);
            return JsonConvert.DeserializeObject<SteamUserResponse>(request).Result.Players.First();
        }

        /// <summary>
        /// Gets the owned games of a Steam user.
        /// </summary>
        /// <param name="steamId">Steam ID 64</param>
        /// <returns></returns>
        public async Task<SteamUserOwnedGames> GetSteamPlayerOwnedGamesAsync(ulong steamId)
        {
            var parameters = $"{SteamIdParameter}{steamId}";
            var request = await GetAsync(PlayerService, GetOwnedGamesUrl, Version1, parameters);
            return JsonConvert.DeserializeObject<SteamUserOwnedGamesResultResponse>(request).Result;
        }

        /// <summary>
        /// Gets the probation status of a Steam user.
        /// </summary>
        /// <param name="steamId"></param>
        /// <returns></returns>
        public async Task<SteamUserProbationStatus> GetSteamUserProbationStatusAsync(ulong steamId)
        {
            var parameters = $"{SteamIdsParameter}{steamId}";
            var request = await GetAsync(SteamUserUrl, GetPlayerBansUrl, Version1, parameters);
            return JsonConvert.DeserializeObject<SteamUserProbationStatusResponse>(request).Result.First();
        }

        /// <summary>
        /// Resolves the vanity url of a Steam user.
        /// </summary>
        /// <param name="vanity">Vanity username</param>
        /// <returns></returns>
        public async Task<SteamVanity> ResolveVanityUrlAsync(string vanity)
        {
            var parameters = $"{VanityUrlParameter}{vanity}";
            var request = await GetAsync(SteamUserUrl, ResolveVanityUrl, Version1, parameters);
            return JsonConvert.DeserializeObject<VanityUserResponse>(request).Result;
        }

        #endregion

        #region ISteamUserStats

        /// <summary>
        /// Gets the the achievements of the Steam user by the specified game.
        /// </summary>
        /// <param name="steamId">Steam ID 64</param>
        /// <param name="appId">Game identity</param>
        /// <returns></returns>
        public async Task<SteamUserGameAchievementSummary> GetSteamUserGameAchievements(ulong steamId, uint appId)
        {
            var parameters = $"{SteamIdParameter}{steamId}{AppIdParameter}{appId}";
            var request = await GetAsync(SteamUserStatsUrl, GetPlayerAchievements, Version1, parameters);
            return JsonConvert.DeserializeObject<SteamUserGameAchievementResponse>(request).Result;
        }

        /// <summary>
        /// Gets the Steam game schema.
        /// </summary>
        /// <param name="appId">Game identity</param>
        /// <returns></returns>
        public async Task<SteamGameSchema> GetSteamGameSchema(uint appId)
        {
            var parameters = $"{AppIdParameter}{appId}";
            var request = await GetAsync(SteamUserStatsUrl, GetSchemaForGame, Version2, parameters);
            return JsonConvert.DeserializeObject<SteamGameSchemaResponse>(request).Result;
        }

        /// <summary>
        /// Gets the statistics of the Steam user by the specified game.
        /// </summary>
        /// <param name="appId">Game identity</param>
        /// <param name="steamId">Steam ID 64</param>
        /// <returns></returns>
        public async Task<SteamPlayerStatsForGameResult> GetSteamUserStatsForGameAsync(uint appId, ulong steamId)
        {
            var parameters = $"{AppIdParameter}{appId}{SteamIdParameter}{steamId}";
            var request = await GetAsync(SteamUserStatsUrl, GetUserStatsForGameUrl, Version2, parameters);
            return JsonConvert.DeserializeObject<SteamPlayerStatsForGameResultResponse>(request).Result;
        }

        #endregion

        private static async Task<string> GetAsync(string interfaceName, string methodName, string methodVersion, string parameters)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var message = await client.GetAsync($"{BaseUrl}/{interfaceName}/{methodName}/{methodVersion}/{KeyParameter}{UserKey}{parameters}");
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
