using System;
using System.Collections.Generic;
using System.Text;
using SteamCSharp.Entities.Statistics.Users.Games.CSGO.Maps;

namespace SteamCSharp.Entities.Statistics.Users.Games.CSGO
{
    public class CounterStrikeGlobalOffensive
    {
        public List<Map> Maps { get; set; }
        public LastMatch LastMatch { get; set; }
    }
}
