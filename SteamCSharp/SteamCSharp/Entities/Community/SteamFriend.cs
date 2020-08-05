using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SteamCSharp.Utilities.JsonConverters;

namespace SteamCSharp.Entities.Community
{
    public class Friend
    {
        [JsonProperty("steamid", NullValueHandling = NullValueHandling.Ignore)] 
        public ulong SteamId { get; set; }

        [JsonProperty("relationship", NullValueHandling = NullValueHandling.Ignore)] 
        public string Relationship { get; set; }

        [JsonProperty("friend_since", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        public DateTime FriendSince { get; set; }
    }

    internal class FriendsList
    {
        [JsonProperty("friends", NullValueHandling = NullValueHandling.Ignore)] 
        public IList<Friend> Friends { get; set; }
    }

    internal class FriendsListResponse
    {
        [JsonProperty("friendslist", NullValueHandling = NullValueHandling.Ignore)] 
        public FriendsList Result { get; set; }
    }
}
