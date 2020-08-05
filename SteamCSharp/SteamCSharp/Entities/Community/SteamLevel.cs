using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SteamCSharp.Entities.Community
{
    public class SteamLevel
    {
        [JsonProperty("player_level", NullValueHandling = NullValueHandling.Ignore)]
        public uint Level { get; set; }
    }

    internal class SteamLevelResponse
    {
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public SteamLevel Result { get; set; }
    }
}
