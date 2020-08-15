using Newtonsoft.Json;

namespace SteamCSharp.Entities.Community
{
    public class SteamVanity
    {
        [JsonProperty("steamid", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SteamId { get; set; }

        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public uint Success { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }

    internal class VanityUserResponse
    {
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public SteamVanity Result { get; set; }
    }
}
