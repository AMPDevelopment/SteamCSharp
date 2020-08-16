namespace SteamCSharp.Entities.Statistics.Users.Games.CounterStrike.Weapons
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Kills { get; set; }
        public int? Shots { get; set; }
        public int? Hits { get; set; }
        public double? Accuracy { get; set; }
        public WeaponType Type { get; set; }
    }
}
