namespace SteamCSharp.Entities.Statistics.Users.Games.CounterStrike.Weapons
{
    public class Weapon
    {
        public string Name { get; set; }
        public double Kills { get; set; }
        public double? Shots { get; set; }
        public double? Hits { get; set; }
        public double? Accuracy { get; set; }
        public WeaponType Type { get; set; }
    }
}
