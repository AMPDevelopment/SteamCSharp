using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteamCSharp.Models.Community.Statistics
{
    public class SteamUserStat
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double Value { get; set; }
    }

    public class SteamUserAchievement
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("achieved", NullValueHandling = NullValueHandling.Ignore)]
        public int Achieved { get; set; }
    }

    public class SteamUserStatsForGameResult
    {
        [JsonProperty("steamID", NullValueHandling = NullValueHandling.Ignore)]
        public string SteamId { get; set; }

        [JsonProperty("gameName", NullValueHandling = NullValueHandling.Ignore)]
        public string GameName { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public IList<SteamUserStat> Stats { get; set; }

        [JsonProperty("achievements", NullValueHandling = NullValueHandling.Ignore)]
        public IList<SteamUserAchievement> Achievements { get; set; }
    }

    internal class SteamUserStatsForGameResponse
    {
        [JsonProperty("playerstats", NullValueHandling = NullValueHandling.Ignore)]
        public SteamUserStatsForGameResult Result { get; set; }
    }
}
