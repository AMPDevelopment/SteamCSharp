using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SteamCSharp.Enums;
using SteamCSharp.Utilities.JsonConverters;

namespace SteamCSharp.Models.Community
{
    public class SteamUser
    {
        [JsonProperty(PropertyName = "steamid", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SteamId { get; set; }

        [JsonProperty(PropertyName = "communityvisibilitystate", NullValueHandling = NullValueHandling.Ignore)]
        public CommunityVisibilityState CommunityVisibilityState { get; set; }

        [JsonProperty(PropertyName = "profilestate", NullValueHandling = NullValueHandling.Ignore)]
        public uint ProfileState { get; set; }

        [JsonProperty(PropertyName = "personaname", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonaName { get; set; }

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
        public PersonaState PersonaState { get; set; }

        [JsonProperty(PropertyName = "realname", NullValueHandling = NullValueHandling.Ignore)]
        public string RealName { get; set; }

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

    internal class SteamUserResult
    {
        public IList<SteamUser> Players { get; set; }
    }

    internal class SteamUserResponse
    {
        [JsonProperty(PropertyName = "response", NullValueHandling = NullValueHandling.Ignore)]
        public SteamUserResult Result { get; set; }
    }
}
