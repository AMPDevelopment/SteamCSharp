using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SteamCSharp.Entities.Community.Statistics
{
    public class SteamPlayerOwnedGame
    {
        [JsonProperty("appid", NullValueHandling = NullValueHandling.Ignore)]
        public uint AppId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("playtime_forever", NullValueHandling = NullValueHandling.Ignore)]
        public uint PlaytimeForever { get; set; }

        [JsonProperty("img_icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgIconUrl { get; set; }

        [JsonProperty("img_logo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgLogoUrl { get; set; }

        [JsonProperty("has_community_visible_stats", NullValueHandling = NullValueHandling.Ignore)]
        public bool HasCommunityVisibleStats { get; set; }

        [JsonProperty("playtime_2weeks", NullValueHandling = NullValueHandling.Ignore)]
        public uint? Playtime2Weeks { get; set; }
    }

    public class SteamPlayerOwnedGamesResult
    {
        [JsonProperty("game_count", NullValueHandling = NullValueHandling.Ignore)]
        public uint GameCount { get; set; }

        [JsonProperty("games", NullValueHandling = NullValueHandling.Ignore)]
        public IList<SteamPlayerOwnedGame> OwnedGames { get; set; }
    }

    internal class SteamPlayerOwnedGamesResultResponse
    {
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public SteamPlayerOwnedGamesResult Result { get; set; }
    }
}
