using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteamCSharp.Entities.Community.Statistics
{
    public class SteamUserStat
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double Value { get; set; }
    }

    public class SteamPlayerAchievement
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("achieved", NullValueHandling = NullValueHandling.Ignore)]
        public int Achieved { get; set; }
    }

    public class SteamPlayerStatsForGameResult
    {
        [JsonProperty("steamID", NullValueHandling = NullValueHandling.Ignore)]
        public string SteamId { get; set; }

        [JsonProperty("gameName", NullValueHandling = NullValueHandling.Ignore)]
        public string GameName { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public IList<SteamUserStat> Stats { get; set; }

        [JsonProperty("achievements", NullValueHandling = NullValueHandling.Ignore)]
        public IList<SteamPlayerAchievement> Achievements { get; set; }
    }

    internal class SteamPlayerStatsForGameResultResponse
    {
        [JsonProperty("playerstats", NullValueHandling = NullValueHandling.Ignore)]
        public SteamPlayerStatsForGameResult Result { get; set; }
    }
}
