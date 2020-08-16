using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SteamCSharp.Utilities.JsonConverters;

namespace SteamCSharp.Models.Community
{
    public class SteamFriend
    {
        [JsonProperty("steamid", NullValueHandling = NullValueHandling.Ignore)] 
        public ulong SteamId { get; set; }

        [JsonProperty("relationship", NullValueHandling = NullValueHandling.Ignore)] 
        public string Relationship { get; set; }

        [JsonProperty("friend_since", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        public DateTime FriendSince { get; set; }
    }

    internal class SteamFriendsResult
    {
        [JsonProperty("friends", NullValueHandling = NullValueHandling.Ignore)] 
        public IList<SteamFriend> SteamFriends { get; set; }
    }

    internal class SteamFriendsResponse
    {
        [JsonProperty("friendslist", NullValueHandling = NullValueHandling.Ignore)] 
        public SteamFriendsResult Result { get; set; }
    }
}
