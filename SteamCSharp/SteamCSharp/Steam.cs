using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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

        private static async Task<string> GetAsync(string interfaceName, string methodName, string methodVersion,
            string parameters)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var message = await client.GetAsync($"{BaseUrl}/{interfaceName}/{methodName}/{methodVersion}/{KeyParameter}{Key}{parameters}");
                if (message.StatusCode == HttpStatusCode.OK) return await message.Content.ReadAsStringAsync();
                throw new SteamExeption(await message.Content.ReadAsStringAsync());
            }
        }

        private class SteamExeption : Exception
        {
            public SteamExeption(string message) : base(message)
            {
            }
        }
    }
}
