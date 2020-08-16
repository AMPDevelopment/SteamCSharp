using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteamCSharp.Models.Community.Statistics
{
    public class SteamUserProbationStatus
    {
        [JsonProperty("SteamId", NullValueHandling = NullValueHandling.Ignore)]
        public string SteamId { get; set; }

        [JsonProperty("CommunityBanned", NullValueHandling = NullValueHandling.Ignore)]
        public bool CommunityBanned { get; set; }

        [JsonProperty("VACBanned", NullValueHandling = NullValueHandling.Ignore)]
        public bool VacBanned { get; set; }

        [JsonProperty("NumberOfVACBans", NullValueHandling = NullValueHandling.Ignore)]
        public uint NumberOfVacBans { get; set; }

        [JsonProperty("DaysSinceLastBan", NullValueHandling = NullValueHandling.Ignore)]
        public uint DaysSinceLastBan { get; set; }

        [JsonProperty("NumberOfGameBans", NullValueHandling = NullValueHandling.Ignore)]
        public uint NumberOfGameBans { get; set; }

        [JsonProperty("EconomyBan", NullValueHandling = NullValueHandling.Ignore)]
        public string EconomyBan { get; set; }
    }

    internal class SteamUserProbationStatusResponse
    {
        [JsonProperty(PropertyName = "players", NullValueHandling = NullValueHandling.Ignore)]
        public IList<SteamUserProbationStatus> Result { get; set; }
    }
}
