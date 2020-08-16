namespace SteamCSharp.Entities.Statistics.Users.Games.CounterStrike
{
    public class LastMatch
    {
        public int TWins { get; set; }
        public int CTWins { get; set; }
        public int Wins { get; set; }
        public int Rounds { get; set; }
        public int MaxPlayers { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public double KillDeathRatio { get; set; }
        public int Damage { get; set; }
        public int MVPs { get; set; }
        public int FavoriteWeaponId { get; set; }
        public int FavoriteWeaponHits { get; set; }
        public int FavoriteWeaponShots { get; set; }
        public int FavoriteWeaponKills { get; set; }
        public double FavoriteWeaponAccuracy { get; set; }
        public int MoneySpent { get; set; }
        public int Dominations { get; set; }
        public int Revenges { get; set; }
        public int ContributionScore { get; set; }
        public int GunGameContributionScore { get; set; }
    }
}
