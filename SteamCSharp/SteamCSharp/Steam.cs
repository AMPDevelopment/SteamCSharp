using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteamCSharp.Entities.Community;
using SteamCSharp.Entities.Community.Statistics;
using SteamCSharp.Entities.Community.Statistics.Game;
using SteamCSharp.Entities.Community.Statistics.User;
using SteamCSharp.Entities.Games;
using SteamCSharp.Entities.Statistics.Users.Games.CSGO;
using SteamCSharp.Entities.Statistics.Users.Games.CSGO.Maps;
using SteamCSharp.Entities.Statistics.Users.Games.CSGO.Weapons;

namespace SteamCSharp
{
    public sealed class Steam
    {
        // Base
        private const string BaseUrl = "https://api.steampowered.com/";

        // Interfaces
        private const string PlayerService = "IPlayerService";

        private const string SteamNewsUrl = "ISteamNews";
        private const string SteamUserUrl = "ISteamUser";
        private const string SteamUserStatsUrl = "ISteamUserStats";

        // Methods
        // Methods - ISteamUser
        private const string GetPlayerSummariesUrl = "GetPlayerSummaries";

        // Todo
        private const string GetFriendListUrl = "GetFriendList";

        // Methods - ISteamUserStats
        private const string GetPlayerAchievements = "GetPlayerAchievements";

        private const string GetOwnedGamesUrl = "GetOwnedGames";
        private const string GetUserStatsForGameUrl = "GetUserStatsForGame";
        private const string GetPlayerBansUrl = "GetPlayerBans";
        private const string ResolveVanityUrl = "ResolveVanityURL";
        private const string GetSchemaForGame = "GetSchemaForGame";

        // Todo
        private const string GetGlobalAchievementPercentagesForApp = "GetGlobalAchievementPercentagesForApp";
        private const string GetNumberOfCurrentPlayers = "GetNumberOfCurrentPlayers";

        // Version
        private const string Version1 = "v1";
        private const string Version2 = "v2";

        // Parameter
        private const string KeyParameter = "?key=";
        private const string AppIdParameter = "&appid=";
        private const string VanityUrlParameter = "&vanityurl=";
        private const string SteamIdParameter = "&steamid=";
        private const string SteamIdsParameter = "&steamids=";
        private const string RelationshipParameter = "&relationship=";

        public Steam(string userKey)
        {
            UserKey = userKey;
        }

        private static string UserKey { get; set; }

        #region ISteamUser

        /// <summary>
        /// Gets the steam user.
        /// </summary>
        /// <param name="steamId">Steam ID 64 or vanity username</param>
        /// <returns></returns>
        public async Task<SteamUser> GetSteamUserAsync(string steamId)
        {
            var result = ulong.TryParse(steamId, out var steamUserId);

            if (!result)
            {
                var vanityUrl = await ResolveVanityUrlAsync(steamId);
                if (vanityUrl.Success == 1)
                {
                    steamUserId = vanityUrl.SteamId;
                }
            }

            var parameters = $"{SteamIdsParameter}{steamUserId}";
            var request = await GetAsync(SteamUserUrl, GetPlayerSummariesUrl, Version2, parameters);
            return JsonConvert.DeserializeObject<SteamUserResponse>(request).Result.Players.First();
        }

        /// <summary>
        /// Gets the owned games of a Steam user.
        /// </summary>
        /// <param name="steamId">Steam ID 64</param>
        /// <returns></returns>
        public async Task<SteamUserOwnedGames> GetSteamPlayerOwnedGamesAsync(ulong steamId)
        {
            var parameters = $"{SteamIdParameter}{steamId}";
            var request = await GetAsync(PlayerService, GetOwnedGamesUrl, Version1, parameters);
            return JsonConvert.DeserializeObject<SteamUserOwnedGamesResultResponse>(request).Result;
        }

        /// <summary>
        /// Gets the probation status of a Steam user.
        /// </summary>
        /// <param name="steamId"></param>
        /// <returns></returns>
        public async Task<SteamUserProbationStatus> GetSteamUserProbationStatusAsync(ulong steamId)
        {
            var parameters = $"{SteamIdsParameter}{steamId}";
            var request = await GetAsync(SteamUserUrl, GetPlayerBansUrl, Version1, parameters);
            return JsonConvert.DeserializeObject<SteamUserProbationStatusResponse>(request).Result.First();
        }

        /// <summary>
        /// Resolves the vanity url of a Steam user.
        /// </summary>
        /// <param name="vanity">Vanity username</param>
        /// <returns></returns>
        public async Task<SteamVanity> ResolveVanityUrlAsync(string vanity)
        {
            var parameters = $"{VanityUrlParameter}{vanity}";
            var request = await GetAsync(SteamUserUrl, ResolveVanityUrl, Version1, parameters);
            return JsonConvert.DeserializeObject<VanityUserResponse>(request).Result;
        }

        #endregion

        #region ISteamUserStats

        /// <summary>
        /// Gets the the achievements of the Steam user by the specified game.
        /// </summary>
        /// <param name="steamId">Steam ID 64</param>
        /// <param name="appId">Game identity</param>
        /// <returns></returns>
        public async Task<SteamUserGameAchievementSummary> GetSteamUserGameAchievements(ulong steamId, uint appId)
        {
            var parameters = $"{SteamIdParameter}{steamId}{AppIdParameter}{appId}";
            var request = await GetAsync(SteamUserStatsUrl, GetPlayerAchievements, Version1, parameters);
            return JsonConvert.DeserializeObject<SteamUserGameAchievementResponse>(request).Result;
        }

        /// <summary>
        /// Gets the Steam game schema.
        /// </summary>
        /// <param name="appId">Game identity</param>
        /// <returns></returns>
        public async Task<SteamGameSchema> GetSteamGameSchema(uint appId)
        {
            var parameters = $"{AppIdParameter}{appId}";
            var request = await GetAsync(SteamUserStatsUrl, GetSchemaForGame, Version2, parameters);
            return JsonConvert.DeserializeObject<SteamGameSchemaResponse>(request).Result;
        }

        /// <summary>
        /// Gets the statistics of the Steam user by the specified game.
        /// </summary>
        /// <param name="appId">Game identity</param>
        /// <param name="steamId">Steam ID 64</param>
        /// <returns></returns>
        public async Task<SteamPlayerStatsForGameResult> GetSteamUserStatsForGameAsync(uint appId, ulong steamId)
        {
            var parameters = $"{AppIdParameter}{appId}{SteamIdParameter}{steamId}";
            var request = await GetAsync(SteamUserStatsUrl, GetUserStatsForGameUrl, Version2, parameters);
            return JsonConvert.DeserializeObject<SteamPlayerStatsForGameResultResponse>(request).Result;
        }

        /// <summary>
        /// Gets the CS:GO statistics of the Steam user.
        /// </summary>
        /// <param name="steamId">Steam ID 64</param>
        /// <returns></returns>
        public async Task<CounterStrikeGlobalOffensive> GetSteamUserStatsForCounterStrikeGlobalOffensiveAsync(ulong steamId)
        {
            var parameters = $"{AppIdParameter}730{SteamIdParameter}{steamId}";
            var request = await GetAsync(SteamUserStatsUrl, GetUserStatsForGameUrl, Version2, parameters);
            var result = JsonConvert.DeserializeObject<CounterStrikeGlobalOffensiveDto>(request);
            return new CounterStrikeGlobalOffensive()
            {
                TotalKills = result.TotalKills,
                TotalKillsHeadshot = result.TotalKillsHeadshot,
                TotalKillsKnifeFight = result.TotalKillsKnifeFight,
                TotalKillsPistolRound = result.TotalKillsPistolRound,
                TotalKillsEnemyWeapon = result.TotalKillsEnemyWeapon,
                TotalKillsEnemyBlinded = result.TotalKillsEnemyBlinded,
                KillDeathRatio = result.TotalKills / result.TotalDeaths,
                TotalDeaths = result.TotalDeaths,
                TotalShotsHit = result.TotalShotsHit,
                TotalShotsFired = result.TotalShotsFired,
                Accuracy = result.TotalShotsHit / result.TotalShotsFired * 100,
                HeadshotAccuracy = result.TotalKillsHeadshot / result.TotalKills * 100,
                TotalTimePlayed = result.TotalTimePlayed,
                TotalWeaponsDonated = result.TotalWeaponsDonated,
                TotalBrokenWindows = result.TotalBrokenWindows,
                TotalDominations = result.TotalDominations,
                TotalDominationOverkills = result.TotalDominationOverkills,
                TotalRevenges = result.TotalRevenges,
                TotalPlantedBombs = result.TotalPlantedBombs,
                TotalDefusedBombs = result.TotalDefusedBombs,
                TotalWins = result.TotalWins,
                TotalDamageDone = result.TotalDamageDone,
                TotalMoneyEarned = result.TotalMoneyEarned,
                TotalRescuedHostages = result.TotalRescuedHostages,
                TotalRoundsPlayed = result.TotalRoundsPlayed,
                TotalMVPs = result.TotalMVPs,
                Weapons = new List<Weapon>()
                {
                    new Weapon()
                    {
                        Name = "AK-47",
                        Kills = result.TotalKillsAK47,
                        Shots = result.TotalShotsAK47,
                        Hits = result.TotalHitsAK47,
                        Accuracy = result.TotalHitsAK47 / result.TotalShotsAK47 * 100,
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "AUG",
                        Kills = result.TotalKillsAUG,
                        Shots = result.TotalShotsAUG,
                        Hits = result.TotalHitsAUG,
                        Accuracy = result.TotalHitsAUG / result.TotalShotsAUG * 100,
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "FAMAS",
                        Kills = result.TotalKillsFAMAS,
                        Shots = result.TotalShotsFAMAS,
                        Hits = result.TotalHitsFAMAS,
                        Accuracy = result.TotalHitsFAMAS / result.TotalShotsFAMAS * 100,
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "Galil AR",
                        Kills = result.TotalKillsGalilAR,
                        Shots = result.TotalShotsGalilAR,
                        Hits = result.TotalHitsGalilAR,
                        Accuracy = result.TotalHitsGalilAR / result.TotalShotsGalilAR * 100,
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "M4A1-S and M4A4",
                        Kills = result.TotalKillsM4A1,
                        Shots = result.TotalShotsM4A1,
                        Hits = result.TotalHitsM4A1,
                        Accuracy = result.TotalHitsM4A1 / result.TotalShotsM4A1 * 100,
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "SG 553",
                        Kills = result.TotalKillsSG553,
                        Shots = result.TotalShotsSG553,
                        Hits = result.TotalHitsSG553,
                        Accuracy = result.TotalHitsSG553 / result.TotalShotsSG553 * 100,
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "AWP",
                        Kills = result.TotalKillsAWP,
                        Shots = result.TotalShotsAWP,
                        Hits = result.TotalHitsAWP,
                        Accuracy = result.TotalHitsAWP / result.TotalShotsAWP * 100,
                        Type = WeaponType.SniperRifle
                    },
                    new Weapon()
                    {
                        Name = "G3SG1",
                        Kills = result.TotalKillsG3SG1,
                        Shots = result.TotalShotsG3SG1,
                        Hits = result.TotalHitsG3SG1,
                        Accuracy = result.TotalHitsG3SG1 / result.TotalShotsG3SG1 * 100,
                        Type = WeaponType.SniperRifle
                    },
                    new Weapon()
                    {
                        Name = "SCAR-20",
                        Kills = result.TotalKillsSCAR20,
                        Shots = result.TotalShotsSCAR20,
                        Hits = result.TotalHitsSCAR20,
                        Accuracy = result.TotalHitsSCAR20 / result.TotalShotsSCAR20 * 100,
                        Type = WeaponType.SniperRifle
                    },
                    new Weapon()
                    {
                        Name = "SSG 08",
                        Kills = result.TotalKillsSSG08,
                        Shots = result.TotalShotsSSG08,
                        Hits = result.TotalHitsSSG08,
                        Accuracy = result.TotalHitsSSG08 / result.TotalShotsSSG08 * 100,
                        Type = WeaponType.SniperRifle
                    },
                    new Weapon()
                    {
                        Name = "MAC-10",
                        Kills = result.TotalKillsMAC10,
                        Shots = result.TotalShotsMAC10,
                        Hits = result.TotalHitsMAC10,
                        Accuracy = result.TotalHitsMAC10 / result.TotalShotsMAC10 * 100,
                        Type = WeaponType.SMG,
                    },
                    // MP5-SD
                    new Weapon()
                    {
                        Name = "MP7",
                        Kills = result.TotalKillsMP7,
                        Shots = result.TotalShotsMP7,
                        Hits = result.TotalHitsMP7,
                        Accuracy = result.TotalHitsMP7 / result.TotalShotsMP7 * 100,
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "MP9",
                        Kills = result.TotalKillsMP9,
                        Shots = result.TotalShotsMP9,
                        Hits = result.TotalHitsMP9,
                        Accuracy = result.TotalHitsMP9 / result.TotalShotsMP9 * 100,
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "P90",
                        Kills = result.TotalKillsP90,
                        Shots = result.TotalShotsP90,
                        Hits = result.TotalHitsP90,
                        Accuracy = result.TotalHitsP90 / result.TotalShotsP90 * 100,
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "PP-Bizon",
                        Kills = result.TotalKillsPPBizon,
                        Shots = result.TotalShotsPPBizon,
                        Hits = result.TotalHitsPPBizon,
                        Accuracy = result.TotalHitsPPBizon / result.TotalShotsPPBizon * 100,
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "UMP-45",
                        Kills = result.TotalKillsUMP45,
                        Shots = result.TotalShotsUMP45,
                        Hits = result.TotalHitsUMP45,
                        Accuracy = result.TotalHitsUMP45 / result.TotalShotsUMP45 * 100,
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "M249",
                        Kills = result.TotalKillsM249,
                        Shots = result.TotalShotsM249,
                        Hits = result.TotalHitsM249,
                        Accuracy = result.TotalHitsM249 / result.TotalShotsM249 * 100,
                        Type = WeaponType.Heavy
                    },
                    new Weapon()
                    {
                        Name = "Negev",
                        Kills = result.TotalKillsNegev,
                        Shots = result.TotalShotsNegev,
                        Hits = result.TotalHitsNegev,
                        Accuracy = result.TotalHitsNegev / result.TotalShotsNegev * 100,
                        Type = WeaponType.Heavy
                    },
                    new Weapon()
                    {
                        Name = "MAG-7",
                        Kills = result.TotalKillsMAG7,
                        Shots = result.TotalShotsMAG7,
                        Hits = result.TotalHitsMAG7,
                        Accuracy = result.TotalHitsMAG7 / result.TotalShotsMAG7 * 100,
                        Type = WeaponType.Shotgun
                    },
                    new Weapon()
                    {
                        Name = "Nova",
                        Kills = result.TotalKillsNova,
                        Shots = result.TotalShotsNova,
                        Hits = result.TotalHitsNova,
                        Accuracy = result.TotalHitsNova / result.TotalShotsNova * 100,
                        Type = WeaponType.Shotgun
                    },
                    new Weapon()
                    {
                        Name = "Sawed-Off",
                        Kills = result.TotalKillsSawedOff,
                        Shots = result.TotalShotsSawedOff,
                        Hits = result.TotalHitsSawedOff,
                        Accuracy = result.TotalHitsSawedOff / result.TotalShotsSawedOff * 100,
                        Type = WeaponType.Shotgun
                    },
                    new Weapon()
                    {
                        Name = "XM1014",
                        Kills = result.TotalKillsXM1014,
                        Shots = result.TotalShotsXM1014,
                        Hits = result.TotalHitsXM1014,
                        Accuracy = result.TotalHitsXM1014 / result.TotalShotsXM1014 * 100,
                        Type = WeaponType.Shotgun
                    },
                    new Weapon()
                    {
                        Name = "Desert Eagle",
                        Kills = result.TotalKillsDeagle,
                        Shots = result.TotalShotsDeagle,
                        Hits = result.TotalHitsDeagle,
                        Accuracy = result.TotalHitsDeagle / result.TotalShotsDeagle * 100,
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "Dual Berettas",
                        Kills = result.TotalKillsDualElite,
                        Shots = result.TotalShotsDualElite,
                        Hits = result.TotalHitsDualElite,
                        Accuracy = result.TotalHitsDualElite / result.TotalShotsDualElite * 100,
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "Five-SeveN",
                        Kills = result.TotalKillsFiveSeven,
                        Shots = result.TotalShotsFiveSeven,
                        Hits = result.TotalHitsFiveSeven,
                        Accuracy = result.TotalHitsFiveSeven / result.TotalShotsFiveSeven * 100,
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "Glock-18",
                        Kills = result.TotalKillsGlock,
                        Shots = result.TotalShotsGlock,
                        Hits = result.TotalHitsGlock,
                        Accuracy = result.TotalHitsGlock / result.TotalShotsGlock * 100,
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "USP-S and HKP2000",
                        Kills = result.TotalKillsHKP2000,
                        Shots = result.TotalShotsHKP2000,
                        Hits = result.TotalHitsHKP2000,
                        Accuracy = result.TotalHitsHKP2000 / result.TotalShotsHKP2000 * 100,
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "P250",
                        Kills = result.TotalKillsP250,
                        Shots = result.TotalShotsP250,
                        Hits = result.TotalHitsP250,
                        Accuracy = result.TotalHitsP250 / result.TotalShotsP250 * 100,
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "Tec-9",
                        Kills = result.TotalKillsTec9,
                        Shots = result.TotalShotsTec9,
                        Hits = result.TotalHitsTec9,
                        Accuracy = result.TotalHitsTec9 / result.TotalShotsTec9 * 100,
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "HE Grenade",
                        Kills = result.TotalKillsHeGrenade,
                        Shots = 0,
                        Hits = 0,
                        Accuracy = 0,
                        Type = WeaponType.Other
                    },
                    new Weapon()
                    {
                        Name = "Decoy",
                        Kills = result.TotalKillsDecoy,
                        Shots = 0,
                        Hits = 0,
                        Accuracy = 0,
                        Type = WeaponType.Other
                    },
                    new Weapon()
                    {
                        Name = "Molotov",
                        Kills = result.TotalKillsMolotov,
                        Shots = 0,
                        Hits = 0,
                        Accuracy = 0,
                        Type = WeaponType.Other
                    },
                    new Weapon()
                    {
                        Name = "Zeus x27",
                        Kills = result.TotalKillsTaser,
                        Shots = result.TotalShotsTaser,
                        Hits = 0,
                        Accuracy = 0,
                        Type = WeaponType.Other
                    },
                    new Weapon()
                    {
                        Name = "Knife",
                        Kills = result.TotalKillsKnife,
                        Shots = 0,
                        Hits = 0,
                        Accuracy = 0,
                        Type = WeaponType.Melee
                    },
                },
                Maps = new List<Map>
                {
                    new Map()
                    {
                        Name = "de_dust2",
                        TotalRounds = result.TotalRoundsDust2,
                        TotalWins = result.TotalWinsDust2
                    },
                    new Map()
                    {
                        Name = "de_dust",
                        TotalRounds = result.TotalRoundsDust,
                        TotalWins = result.TotalWinsDust
                    },
                    new Map()
                    {
                        Name = "cs_assault",
                        TotalRounds = result.TotalRoundsAssault,
                        TotalWins = result.TotalWinsAssault
                    },
                    new Map()
                    {
                        Name = "de_aztec",
                        TotalRounds = result.TotalRoundsAztec,
                        TotalWins = result.TotalWinsAztec
                    },
                    new Map()
                    {
                        Name = "de_cbble",
                        TotalRounds = result.TotalRoundsCobblestone,
                        TotalWins = result.TotalWinsCobblestone
                    },
                    new Map()
                    {
                        Name = "de_inferno",
                        TotalRounds = result.TotalRoundsInferno,
                        TotalWins = result.TotalWinsInferno
                    },
                    new Map()
                    {
                        Name = "cs_italy",
                        TotalRounds = result.TotalRoundsItaly,
                        TotalWins = result.TotalWinsItaly
                    },
                    new Map()
                    {
                        Name = "de_nuke",
                        TotalRounds = result.TotalRoundsNuke,
                        TotalWins = result.TotalWinsNuke
                    },
                    new Map()
                    {
                        Name = "cs_office",
                        TotalRounds = result.TotalRoundsOffice,
                        TotalWins = result.TotalWinsOffice
                    },
                    new Map()
                    {
                        Name = "de_train",
                        TotalRounds = result.TotalRoundsTrain,
                        TotalWins = result.TotalWinsTrain
                    },
                    new Map()
                    {
                        Name = "de_lake",
                        TotalRounds = result.TotalRoundsLake,
                        TotalWins = result.TotalWinsLake
                    },
                    new Map()
                    {
                        Name = "de_safehouse",
                        TotalRounds = result.TotalRoundsSafehouse,
                        TotalWins = result.TotalWinsSafehouse
                    },
                    new Map()
                    {
                        Name = "de_sugarcane",
                        TotalRounds = result.TotalRoundsSugarcane,
                        TotalWins = result.TotalWinsSugarcane
                    },
                    new Map()
                    {
                        Name = "de_stmarc",
                        TotalRounds = result.TotalRoundsStMarc,
                        TotalWins = result.TotalWinsStMarc
                    },
                    new Map()
                    {
                        Name = "de_bank",
                        TotalRounds = result.TotalRoundsBank,
                        TotalWins = result.TotalWinsBank
                    },
                    new Map()
                    {
                        Name = "de_shorttrain",
                        TotalRounds = result.TotalRoundsShortTrain,
                        TotalWins = result.TotalWinsShortTrain
                    },
                    new Map()
                    {
                        Name = "ar_shoots",
                        TotalRounds = result.TotalRoundsShoots,
                        TotalWins = result.TotalWinsShoots
                    },
                    new Map()
                    {
                        Name = "ar_baggage",
                        TotalRounds = result.TotalRoundsBaggage,
                        TotalWins = result.TotalWinsBaggage
                    },
                    new Map()
                    {
                        Name = "de_house",
                        TotalWins = result.TotalWinsHouse
                    },
                    new Map()
                    {
                        Name = "ar_monastery",
                        TotalRounds = result.TotalRoundsMonastery,
                        TotalWins = result.TotalWinsMonastery
                    },
                    new Map()
                    {
                        Name = "de_vertigo",
                        TotalRounds = result.TotalRoundsVertigo,
                        TotalWins = result.TotalWinsVertigo
                    }, 
                    new Map()
                    {
                        Name = "cs_militia",
                        TotalRounds = result.TotalRoundsMilitia,
                        TotalWins = result.TotalWinsMilitia
                    }
                },
                LastMatch = new LastMatch()
                {
                    CTWins = result.LastMatchCTWins,
                    TWins = result.LastMatchTWins,
                    Wins = result.LastMatchWins,
                    Rounds = result.LastMatchRounds,
                    MaxPlayers = result.LastMatchMaxPlayers,
                    Kills = result.LastMatchKills,
                    Deaths = result.LastMatchDeaths,
                    Damage = result.LastMatchDamage,
                    MVPs = result.LastMatchMVPs,
                    FavoriteWeaponId = result.LastMatchFavoriteWeaponId,
                    FavoriteWeaponShots = result.LastMatchFavoriteWeaponShots,
                    FavoriteWeaponKills = result.LastMatchFavoriteWeaponKills,
                    MoneySpent = result.LastMatchMoneySpent,
                    Dominations = result.LastMatchDominations,
                    Revenges = result.LastMatchRevenges,
                    ContributionScore = result.LastMatchContributionScore,
                    GunGameContributionScore = result.LastMatchGunGameContributionScore
                }
            };
        }

        #endregion

        private static async Task<string> GetAsync(string interfaceName, string methodName, string methodVersion, string parameters)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var message = await client.GetAsync($"{BaseUrl}/{interfaceName}/{methodName}/{methodVersion}/{KeyParameter}{UserKey}{parameters}");
                if (message.StatusCode == HttpStatusCode.OK) return await message.Content.ReadAsStringAsync();
                throw new SteamException(await message.Content.ReadAsStringAsync());
            }
        }

        private class SteamException : Exception
        {
            public SteamException(string message) : base(message)
            {
            }
        }
    }
}
