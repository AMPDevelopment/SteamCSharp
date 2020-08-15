using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteamCSharp.Entities.Community.Statistics.Game
{
    public class SteamGameSchema
    {
        [JsonProperty("gameName", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("gameVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("availableGameStats", NullValueHandling = NullValueHandling.Ignore)]
        public SteamGameSchemaAvailableStatsSummary AvailableGameStats { get; set; }
    }

    public class SteamGameSchemaAvailableStatsSummary
    {
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public List<SteamGameStat> SteamGameStats { get; set; }

        [JsonProperty("achievements", NullValueHandling = NullValueHandling.Ignore)]
        public List<SteamGameAchievement> SteamGameAchievements { get; set; }
    }

    internal class SteamGameSchemaResponse
    {
        [JsonProperty("game", NullValueHandling = NullValueHandling.Ignore)]
        public SteamGameSchema Result { get; set; }
    }
}
