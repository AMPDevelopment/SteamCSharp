using Newtonsoft.Json;

namespace SteamCSharp.Models.Community.Statistics.Game
{
    public class SteamGameStat
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("defaultvalue", NullValueHandling = NullValueHandling.Ignore)]
        public double DefaultValue { get; set; }

        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }
    }
}
