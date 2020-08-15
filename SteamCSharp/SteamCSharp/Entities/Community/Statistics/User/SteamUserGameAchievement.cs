using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteamCSharp.Entities.Community.Statistics.User
{
    public class SteamUserGameAchievementSummary
    {
        [JsonProperty("steamID", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SteamId { get; set; }

        [JsonProperty("gameName", NullValueHandling = NullValueHandling.Ignore)]
        public string GameName { get; set; }

        [JsonProperty("achievements", NullValueHandling = NullValueHandling.Ignore)]
        public List<SteamUserAchievement> SteamUserAchievements { get; set; }
    }

    internal class SteamUserGameAchievementResponse
    {
        [JsonProperty("playerstats", NullValueHandling = NullValueHandling.Ignore)]
        public SteamUserGameAchievementSummary Result { get; set; }
    }
}
