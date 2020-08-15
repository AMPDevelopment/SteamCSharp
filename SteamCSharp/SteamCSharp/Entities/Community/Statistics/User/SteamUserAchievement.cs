using System;
using Newtonsoft.Json;
using SteamCSharp.Utilities.JsonConverters;

namespace SteamCSharp.Entities.Community.Statistics.User
{
    public class SteamUserAchievement
    {
        [JsonProperty("apiname", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiName { get; set; }

        [JsonProperty("achieved", NullValueHandling = NullValueHandling.Ignore)]
        public bool Achieved { get; set; }

        [JsonProperty(PropertyName = "unlocktime", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        public DateTime UnlockTime { get; set; }
    }
}
