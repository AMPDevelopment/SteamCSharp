using System.Collections.Generic;
using SteamCSharp.Entities.Statistics.Users.Games.CounterStrike.Maps;
using SteamCSharp.Entities.Statistics.Users.Games.CounterStrike.Weapons;

namespace SteamCSharp.Entities.Statistics.Users.Games.CounterStrike
{
    public class GlobalOffensive
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
        public int TotalMatchesWon { get; set; }
        public int TotalMatchesPlayed { get; set; }
        public double MatchesWinPercentage { get; set; }
        public int TotalGunGameMatchesWon { get; set; }
        public int TotalGunGameMatchesPlayed { get; set; }
        public double GunGameMatchesWinPercentage { get; set; }
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
        public int TotalContributionScore { get; set; }
        public int TotalGunGameContributionScore { get; set; }
        public int TotalGunGameRoundsWon { get; set; }
        public int TotalGunGameRoundsPlayed { get; set; }
        // Todo: total_progressive_matches_won
        // Todo: total_TR_planted_bombs
        // Todo: total_TR_defused_bombs
        // Todo: total_trbomb_matches_won
        public List<Weapon> Weapons { get; set; }
        public List<Map> Maps { get; set; }
        public LastMatch LastMatch { get; set; }
    }
}
