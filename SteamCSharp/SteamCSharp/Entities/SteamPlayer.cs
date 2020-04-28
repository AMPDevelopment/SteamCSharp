using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SteamCSharp.Enums;
using SteamCSharp.Utilities.JsonConverters;

namespace SteamCSharp.Entities
{

    public class SteamPlayer
    {
        [JsonProperty(PropertyName = "steamid", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SteamId { get; set; }

        [JsonProperty(PropertyName = "communityvisibilitystate", NullValueHandling = NullValueHandling.Ignore)]
        public CommunityVisibilityState CommunityVisibilityState { get; set; }

        [JsonProperty(PropertyName = "profilestate", NullValueHandling = NullValueHandling.Ignore)]
        public uint ProfileState { get; set; }

        [JsonProperty(PropertyName = "personaname", NullValueHandling = NullValueHandling.Ignore)]
        public string Personaname { get; set; }

        [JsonProperty(PropertyName = "lastlogoff", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        public DateTime LastLoggedOffDate { get; set; }

        [JsonProperty(PropertyName = "commentpermission", NullValueHandling = NullValueHandling.Ignore)]
        public int CommentPermission { get; set; }

        [JsonProperty(PropertyName = "profileurl", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileUrl { get; set; }

        [JsonProperty(PropertyName = "avatar", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarUrl { get; set; }

        [JsonProperty(PropertyName = "avatarmedium", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarMediumUrl { get; set; }

        [JsonProperty(PropertyName = "avatarfull", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarFullUrl { get; set; }

        [JsonProperty(PropertyName = "personastate", NullValueHandling = NullValueHandling.Ignore)]
        public PersonasState PersonaState { get; set; }

        [JsonProperty(PropertyName = "realname", NullValueHandling = NullValueHandling.Ignore)]
        public string Realname { get; set; }

        [JsonProperty(PropertyName = "primaryclanid", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryClanId { get; set; }

        [JsonProperty(PropertyName = "timecreated", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        public DateTime AccountCreatedDate { get; set; }

        [JsonProperty(PropertyName = "loccountrycode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        [JsonProperty(PropertyName = "locstatecode", NullValueHandling = NullValueHandling.Ignore)]
        public string StateCode { get; set; }

        [JsonProperty(PropertyName = "loccityid", NullValueHandling = NullValueHandling.Ignore)]
        public uint CityCode { get; set; }

        [JsonProperty(PropertyName = "gameextrainfo", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayingGameName { get; set; }

        [JsonProperty(PropertyName = "gameid", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayingGameId { get; set; }
    }

    internal class SteamPlayerResult
    {
        public IList<SteamPlayer> Players { get; set; }
    }

    internal class SteamPlayerResponse
    {
        [JsonProperty(PropertyName = "response", NullValueHandling = NullValueHandling.Ignore)]
        public SteamPlayerResult Result { get; set; }
    }
}
