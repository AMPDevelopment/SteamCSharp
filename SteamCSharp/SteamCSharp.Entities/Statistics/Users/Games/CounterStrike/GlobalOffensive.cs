using System.Collections.Generic;
using SteamCSharp.Entities.Statistics.Users.Games.CounterStrike.Maps;
using SteamCSharp.Entities.Statistics.Users.Games.CounterStrike.Weapons;

namespace SteamCSharp.Entities.Statistics.Users.Games.CounterStrike
{
    public class GlobalOffensive
    {
        public double TotalKills { get; set; }
        public double TotalKillsHeadshot { get; set; }
        public double TotalKillsKnifeFight { get; set; }
        public double TotalKillsPistolRound { get; set; }
        public double TotalKillsEnemyWeapon { get; set; }
        public double TotalKillsEnemyBlinded { get; set; }
        public double TotalKillsAgainstZoomedSniper { get; set; }
        public double KillDeathRatio { get; set; }
        public double TotalDeaths { get; set; }
        public double TotalShotsHit { get; set; }
        public double TotalShotsFired { get; set; }
        public double Accuracy { get; set; }
        public double HeadshotAccuracy { get; set; }
        public double TotalTimePlayed { get; set; }
        public double TotalMatchesWon { get; set; }
        public double TotalMatchesPlayed { get; set; }
        public double MatchesWinPercentage { get; set; }
        public double TotalGunGameMatchesWon { get; set; }
        public double TotalGunGameMatchesPlayed { get; set; }
        public double GunGameMatchesWinPercentage { get; set; }
        public double TotalWeaponsDonated { get; set; }
        public double TotalBrokenWindows { get; set; }
        public double TotalDominations { get; set; }
        public double TotalDominationOverkills { get; set; }
        public double TotalRevenges { get; set; }
        public double TotalPlantedBombs { get; set; }
        public double TotalDefusedBombs { get; set; }
        public double TotalWins { get; set; }
        public double TotalDamageDone { get; set; }
        public double TotalMoneyEarned { get; set; }
        public double TotalRescuedHostages { get; set; }
        public double TotalRoundsPlayed { get; set; }
        public double TotalMVPs { get; set; }
        public double TotalContributionScore { get; set; }
        public double TotalGunGameContributionScore { get; set; }
        public double TotalGunGameRoundsWon { get; set; }
        public double TotalGunGameRoundsPlayed { get; set; }
        // Todo: total_progressive_matches_won
        // Todo: total_TR_planted_bombs
        // Todo: total_TR_defused_bombs
        // Todo: total_trbomb_matches_won
        public List<Weapon> Weapons { get; set; }
        public List<Map> Maps { get; set; }
        public LastMatch LastMatch { get; set; }
    }
}
