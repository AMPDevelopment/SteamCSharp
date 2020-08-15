using Newtonsoft.Json;

namespace SteamCSharp.Entities.Community.Statistics.Game
{
    public class SteamGameAchievement
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("defaultvalue", NullValueHandling = NullValueHandling.Ignore)]
        public double DefaultValue { get; set; }

        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool Hidden { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("icongray", NullValueHandling = NullValueHandling.Ignore)]
        public string IconGray { get; set; }
    }
}
