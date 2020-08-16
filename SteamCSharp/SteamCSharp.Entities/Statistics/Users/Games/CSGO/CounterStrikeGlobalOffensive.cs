using System.Collections.Generic;
using SteamCSharp.Entities.Statistics.Users.Games.CSGO.Maps;
using SteamCSharp.Entities.Statistics.Users.Games.CSGO.Weapons;

namespace SteamCSharp.Entities.Statistics.Users.Games.CSGO
{
    public class CounterStrikeGlobalOffensive
    {
        public int TotalKills { get; set; }
        public int TotalKillsHeadshot { get; set; }
        public int TotalKillsKnifeFight { get; set; }
        public int TotalKillsPistolRound { get; set; }
        public int TotalKillsEnemyWeapon { get; set; }
        public int TotalKillsEnemyBlinded { get; set; }
        public int TotalKillsAgainstZoomedSniper { get; set; }
        public double KillDeathRatio { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalShotsHit { get; set; }
        public int TotalShotsFired { get; set; }
        public double Accuracy { get; set; }
        public double HeadshotAccuracy { get; set; }
        public int TotalTimePlayed { get; set; }
        public int TotalWeaponsDonated { get; set; }
        public int TotalBrokenWindows { get; set; }
        public int TotalDominations { get; set; }
        public int TotalDominationOverkills { get; set; }
        public int TotalRevenges { get; set; }
        public int TotalPlantedBombs { get; set; }
        public int TotalDefusedBombs { get; set; }
        public int TotalWins { get; set; }
        public int TotalDamageDone { get; set; }
        public int TotalMoneyEarned { get; set; }
        public int TotalRescuedHostages { get; set; }
        public int TotalRoundsPlayed { get; set; }
        public int TotalMVPs { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Map> Maps { get; set; }
        public LastMatch LastMatch { get; set; }
    }
}
