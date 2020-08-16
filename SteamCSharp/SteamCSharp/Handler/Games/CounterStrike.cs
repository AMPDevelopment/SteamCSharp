using System;
using System.Collections.Generic;
using System.Linq;
using SteamCSharp.Entities.Statistics.Users.Games.CounterStrike;
using SteamCSharp.Entities.Statistics.Users.Games.CounterStrike.Maps;
using SteamCSharp.Entities.Statistics.Users.Games.CounterStrike.Weapons;
using SteamCSharp.Models.Community.Statistics;

namespace SteamCSharp.Handler.Games
{
    public static class CounterStrike
    {
        public static GlobalOffensive ReadableStats(IList<SteamUserStat> stats)
        {
            var totalKills = stats.FirstOrDefault(s => s.Name == "total_kills").Value;
            var totalKillsHeadshot = stats.FirstOrDefault(s => s.Name == "total_kills_headshot").Value;
            var totalDeaths = stats.FirstOrDefault(s => s.Name == "total_deaths").Value;
            var totalShotsHit = stats.FirstOrDefault(s => s.Name == "total_shots_hit").Value;
            var totalShotsFired = stats.FirstOrDefault(s => s.Name == "total_shots_fired").Value;
            var totalMatchesWon = stats.FirstOrDefault(s => s.Name == "total_matches_won").Value;
            var totalMatchesPlayed = stats.FirstOrDefault(s => s.Name == "total_matches_played").Value;
            var totalGunGameMatchesWon = stats.FirstOrDefault(s => s.Name == "total_gg_matches_won").Value;
            var totalGunGameMatchesPlayed = stats.FirstOrDefault(s => s.Name == "total_gg_matches_played").Value;
            var totalHitsAK47 = stats.FirstOrDefault(s => s.Name == "total_hits_ak47").Value;
            var totalShotsAK47 = stats.FirstOrDefault(s => s.Name == "total_shots_ak47").Value;
            var totalHitsAUG = stats.FirstOrDefault(s => s.Name == "total_hits_aug").Value;
            var totalShotsAUG = stats.FirstOrDefault(s => s.Name == "total_shots_aug").Value;
            var totalHitsFAMAS = stats.FirstOrDefault(s => s.Name == "total_hits_famas").Value;
            var totalShotsFAMAS = stats.FirstOrDefault(s => s.Name == "total_shots_famas").Value;
            var totalHitsGalilAR = stats.FirstOrDefault(s => s.Name == "total_hits_galilar").Value;
            var totalShotsGalilAR = stats.FirstOrDefault(s => s.Name == "total_shots_galilar").Value;
            var totalHitsM4A1 = stats.FirstOrDefault(s => s.Name == "total_hits_m4a1").Value;
            var totalShotsM4A1 = stats.FirstOrDefault(s => s.Name == "total_shots_m4a1").Value;
            var totalHitsSG553 = stats.FirstOrDefault(s => s.Name == "total_hits_sg556").Value;
            var totalShotsSG553 = stats.FirstOrDefault(s => s.Name == "total_shots_sg556").Value;
            var totalHitsAWP = stats.FirstOrDefault(s => s.Name == "total_hits_awp").Value;
            var totalShotsAWP = stats.FirstOrDefault(s => s.Name == "total_shots_awp").Value;
            var totalHitsG3SG1 = stats.FirstOrDefault(s => s.Name == "total_hits_g3sg1").Value;
            var totalShotsG3SG1 = stats.FirstOrDefault(s => s.Name == "total_shots_g3sg1").Value;
            var totalHitsSCAR20 = stats.FirstOrDefault(s => s.Name == "total_hits_scar20").Value;
            var totalShotsSCAR20 = stats.FirstOrDefault(s => s.Name == "total_shots_scar20").Value;
            var totalHitsSSG08 = stats.FirstOrDefault(s => s.Name == "total_hits_ssg08").Value;
            var totalShotsSSG08 = stats.FirstOrDefault(s => s.Name == "total_shots_ssg08").Value;
            var totalHitsMAC10 = stats.FirstOrDefault(s => s.Name == "total_hits_mac10").Value;
            var totalShotsMAC10 = stats.FirstOrDefault(s => s.Name == "total_shots_mac10").Value;
            var totalHitsMP7 = stats.FirstOrDefault(s => s.Name == "total_hits_mp7").Value;
            var totalShotsMP7 = stats.FirstOrDefault(s => s.Name == "total_shots_mp7").Value;
            var totalHitsMP9 = stats.FirstOrDefault(s => s.Name == "total_hits_mp9").Value;
            var totalShotsMP9 = stats.FirstOrDefault(s => s.Name == "total_shots_mp9").Value;
            var totalHitsP90 = stats.FirstOrDefault(s => s.Name == "total_hits_p90").Value;
            var totalShotsP90 = stats.FirstOrDefault(s => s.Name == "total_shots_p90").Value;
            var totalHitsPPBizon = stats.FirstOrDefault(s => s.Name == "total_hits_bizon").Value;
            var totalShotsPPBizon = stats.FirstOrDefault(s => s.Name == "total_shots_bizon").Value;
            var totalHitsUMP45 = stats.FirstOrDefault(s => s.Name == "total_hits_ump45").Value;
            var totalShotsUMP45 = stats.FirstOrDefault(s => s.Name == "total_shots_ump45").Value;
            var totalHitsM249 = stats.FirstOrDefault(s => s.Name == "total_hits_m249").Value;
            var totalShotsM249 = stats.FirstOrDefault(s => s.Name == "total_shots_m249").Value;
            var totalHitsNegev = stats.FirstOrDefault(s => s.Name == "total_hits_negev").Value;
            var totalShotsNegev = stats.FirstOrDefault(s => s.Name == "total_shots_negev").Value;
            var totalHitsMAG7 = stats.FirstOrDefault(s => s.Name == "total_hits_mag7").Value;
            var totalShotsMAG7 = stats.FirstOrDefault(s => s.Name == "total_shots_mag7").Value;
            var totalHitsNova = stats.FirstOrDefault(s => s.Name == "total_hits_nova").Value;
            var totalShotsNova = stats.FirstOrDefault(s => s.Name == "total_shots_nova").Value;
            var totalHitsSawedOff = stats.FirstOrDefault(s => s.Name == "total_hits_sawedoff").Value;
            var totalShotsSawedOff = stats.FirstOrDefault(s => s.Name == "total_shots_sawedoff").Value;
            var totalHitsXM1014 = stats.FirstOrDefault(s => s.Name == "total_hits_xm1014").Value;
            var totalShotsXM1014 = stats.FirstOrDefault(s => s.Name == "total_shots_xm1014").Value;
            var totalHitsDesertEagle = stats.FirstOrDefault(s => s.Name == "total_hits_deagle").Value;
            var totalShotsDesertEagle = stats.FirstOrDefault(s => s.Name == "total_shots_deagle").Value;
            var totalHitsDualBerettas = stats.FirstOrDefault(s => s.Name == "total_hits_elite").Value;
            var totalShotsDualBerettas = stats.FirstOrDefault(s => s.Name == "total_shots_elite").Value;
            var totalHitsFiveSeveN = stats.FirstOrDefault(s => s.Name == "total_hits_fiveseven").Value;
            var totalShotsFiveSeveN = stats.FirstOrDefault(s => s.Name == "total_shots_fiveseven").Value;
            var totalHitsGlock18 = stats.FirstOrDefault(s => s.Name == "total_hits_glock").Value;
            var totalShotsGlock18 = stats.FirstOrDefault(s => s.Name == "total_shots_glock").Value;
            var totalHitsHKP2000 = stats.FirstOrDefault(s => s.Name == "total_hits_hkp2000").Value;
            var totalShotsHKP2000 = stats.FirstOrDefault(s => s.Name == "total_shots_hkp2000").Value;
            var totalHitsP250 = stats.FirstOrDefault(s => s.Name == "total_hits_p250").Value;
            var totalShotsP250 = stats.FirstOrDefault(s => s.Name == "total_shots_p250").Value;
            var totalHitsTec9 = stats.FirstOrDefault(s => s.Name == "total_hits_tec9").Value;
            var totalShotsTec9 = stats.FirstOrDefault(s => s.Name == "total_shots_tec9").Value;
            var lastMatchKills = stats.FirstOrDefault(s => s.Name == "last_match_kills").Value;
            var lastMatchDeaths = stats.FirstOrDefault(s => s.Name == "last_match_deaths").Value;
            var lastMatchFavoriteWeaponHits = stats.FirstOrDefault(s => s.Name == "last_match_favweapon_hits").Value;
            var lastMatchFavoriteWeaponShots = stats.FirstOrDefault(s => s.Name == "last_match_favweapon_shots").Value;

            return new GlobalOffensive()
            {
                TotalKills = totalKills,
                TotalKillsHeadshot = totalKillsHeadshot,
                TotalKillsKnifeFight = stats.FirstOrDefault(s => s.Name == "total_kills_knife_fight").Value,
                TotalKillsPistolRound = stats.FirstOrDefault(s => s.Name == "total_wins_pistolround").Value,
                TotalKillsEnemyWeapon = stats.FirstOrDefault(s => s.Name == "total_kills_enemy_weapon").Value,
                TotalKillsEnemyBlinded = stats.FirstOrDefault(s => s.Name == "total_kills_enemy_blinded").Value,
                TotalKillsAgainstZoomedSniper = stats.FirstOrDefault(s => s.Name == "total_kills_against_zoomed_sniper").Value,
                KillDeathRatio = Math.Round(totalKills / totalDeaths, 2),
                TotalDeaths = totalDeaths,
                TotalShotsHit = totalShotsHit,
                TotalShotsFired = totalShotsFired,
                Accuracy = Math.Round(totalShotsHit / totalShotsFired * 100, 2),
                HeadshotAccuracy = Math.Round(totalKillsHeadshot / totalKills * 100, 2),
                TotalTimePlayed = stats.FirstOrDefault(s => s.Name == "total_time_played").Value,
                TotalMatchesWon = totalMatchesWon,
                TotalMatchesPlayed = totalMatchesPlayed,
                MatchesWinPercentage = Math.Round(totalMatchesWon / totalMatchesPlayed * 100, 2),
                TotalGunGameMatchesWon = totalGunGameMatchesWon,
                TotalGunGameMatchesPlayed = totalGunGameMatchesPlayed,
                GunGameMatchesWinPercentage = Math.Round(totalGunGameMatchesWon / totalGunGameMatchesPlayed * 100, 2),
                TotalWeaponsDonated = stats.FirstOrDefault(s => s.Name == "total_weapons_donated").Value,
                TotalBrokenWindows = stats.FirstOrDefault(s => s.Name == "total_broken_windows").Value,
                TotalDominations = stats.FirstOrDefault(s => s.Name == "total_dominations").Value,
                TotalDominationOverkills = stats.FirstOrDefault(s => s.Name == "total_domination_overkills").Value,
                TotalRevenges = stats.FirstOrDefault(s => s.Name == "total_revenges").Value,
                TotalPlantedBombs = stats.FirstOrDefault(s => s.Name == "total_planted_bombs").Value,
                TotalDefusedBombs = stats.FirstOrDefault(s => s.Name == "total_defused_bombs").Value,
                TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins").Value,
                TotalDamageDone = stats.FirstOrDefault(s => s.Name == "total_damage_done").Value,
                TotalMoneyEarned = stats.FirstOrDefault(s => s.Name == "total_money_earned").Value,
                TotalRescuedHostages = stats.FirstOrDefault(s => s.Name == "total_rescued_hostages").Value,
                TotalRoundsPlayed = stats.FirstOrDefault(s => s.Name == "total_rounds_played").Value,
                TotalGunGameRoundsWon = stats.FirstOrDefault(s => s.Name == "total_gun_game_rounds_won").Value,
                TotalGunGameRoundsPlayed = stats.FirstOrDefault(s => s.Name == "total_gun_game_rounds_played").Value,
                TotalMVPs = stats.FirstOrDefault(s => s.Name == "total_mvps").Value,
                TotalContributionScore = stats.FirstOrDefault(s => s.Name == "total_contribution_score").Value,
                TotalGunGameContributionScore = stats.FirstOrDefault(s => s.Name == "total_gun_game_contribution_score").Value,
                Weapons = new List<Weapon>()
                {
                    new Weapon()
                    {
                        Name = "AK-47",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_ak47").Value,
                        Shots = totalShotsAK47,
                        Hits = totalHitsAK47,
                        Accuracy = Math.Round(totalHitsAK47 / totalShotsAK47 * 100, 2),
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "AUG",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_aug").Value,
                        Shots = totalShotsAUG,
                        Hits = totalHitsAUG,
                        Accuracy = Math.Round(totalHitsAUG  / totalShotsAUG, 2),
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "FAMAS",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_famas").Value,
                        Shots = totalShotsFAMAS,
                        Hits = totalHitsFAMAS,
                        Accuracy = Math.Round(totalHitsFAMAS  / totalShotsFAMAS, 2),
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "Galil AR",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_galilar").Value,
                        Shots = totalShotsGalilAR,
                        Hits = totalHitsGalilAR,
                        Accuracy = Math.Round(totalHitsGalilAR  / totalShotsGalilAR, 2),
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "M4A1-S and M4A4",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_m4a1").Value,
                        Shots = totalShotsM4A1,
                        Hits = totalHitsM4A1,
                        Accuracy = Math.Round(totalHitsM4A1  / totalShotsM4A1, 2),
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "SG 553",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_sg556").Value,
                        Shots = totalShotsSG553,
                        Hits = totalHitsSG553,
                        Accuracy = Math.Round(totalHitsSG553  / totalShotsSG553, 2),
                        Type = WeaponType.Rifle
                    },
                    new Weapon()
                    {
                        Name = "AWP",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_awp").Value,
                        Shots = totalShotsAWP,
                        Hits = totalHitsAWP,
                        Accuracy = Math.Round(totalHitsAWP  / totalShotsAWP, 2),
                        Type = WeaponType.SniperRifle
                    },
                    new Weapon()
                    {
                        Name = "G3SG1",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_g3sg1").Value,
                        Shots = totalShotsG3SG1,
                        Hits = totalHitsG3SG1,
                        Accuracy = Math.Round(totalHitsG3SG1  / totalShotsG3SG1, 2),
                        Type = WeaponType.SniperRifle
                    },
                    new Weapon()
                    {
                        Name = "SCAR-20",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_scar20").Value,
                        Shots = totalShotsSCAR20,
                        Hits = totalHitsSCAR20,
                        Accuracy = Math.Round(totalHitsSCAR20  / totalShotsSCAR20, 2),
                        Type = WeaponType.SniperRifle
                    },
                    new Weapon()
                    {
                        Name = "SSG 08",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_ssg08").Value,
                        Shots = totalShotsSSG08,
                        Hits = totalHitsSSG08,
                        Accuracy = Math.Round(totalHitsSSG08  / totalShotsSSG08, 2),
                        Type = WeaponType.SniperRifle
                    },
                    new Weapon()
                    {
                        Name = "MAC-10",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_mac10").Value,
                        Shots = totalShotsMAC10,
                        Hits = totalHitsMAC10,
                        Accuracy = Math.Round(totalHitsMAC10  / totalShotsMAC10, 2),
                        Type = WeaponType.SMG,
                    },
                    // MP5-SD
                    new Weapon()
                    {
                        Name = "MP7",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_mp7").Value,
                        Shots = totalShotsMP7,
                        Hits = totalHitsMP7,
                        Accuracy = Math.Round(totalHitsMP7  / totalShotsMP7, 2),
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "MP9",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_mp9").Value,
                        Shots = totalShotsMP9,
                        Hits = totalHitsMP9,
                        Accuracy = Math.Round(totalHitsMP9  / totalShotsMP9, 2),
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "P90",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_p90").Value,
                        Shots = totalShotsP90,
                        Hits = totalHitsP90,
                        Accuracy = Math.Round(totalHitsP90  / totalShotsP90, 2),
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "PP-Bizon",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_bizon").Value,
                        Shots = totalShotsPPBizon,
                        Hits = totalHitsPPBizon,
                        Accuracy = Math.Round(totalHitsPPBizon  / totalShotsPPBizon ,2),
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "UMP-45",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_ump45").Value,
                        Shots = totalShotsUMP45,
                        Hits = totalHitsUMP45,
                        Accuracy = Math.Round(totalHitsUMP45  / totalShotsUMP45, 2),
                        Type = WeaponType.SMG
                    },
                    new Weapon()
                    {
                        Name = "M249",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_m249").Value,
                        Shots = totalShotsM249,
                        Hits = totalHitsM249,
                        Accuracy = Math.Round(totalHitsM249  / totalShotsM249, 2),
                        Type = WeaponType.Heavy
                    },
                    new Weapon()
                    {
                        Name = "Negev",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_negev").Value,
                        Shots = totalShotsNegev,
                        Hits = totalHitsNegev,
                        Accuracy = Math.Round(totalHitsNegev  / totalShotsNegev, 2),
                        Type = WeaponType.Heavy
                    },
                    new Weapon()
                    {
                        Name = "MAG-7",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_mag7").Value,
                        Shots = totalShotsMAG7,
                        Hits = totalHitsMAG7,
                        Accuracy = Math.Round(totalHitsMAG7  / totalShotsMAG7, 2),
                        Type = WeaponType.Shotgun
                    },
                    new Weapon()
                    {
                        Name = "Nova",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_nova").Value,
                        Shots = totalShotsNova,
                        Hits = totalHitsNova,
                        Accuracy = Math.Round(totalHitsNova  / totalShotsNova, 2),
                        Type = WeaponType.Shotgun
                    },
                    new Weapon()
                    {
                        Name = "Sawed-Off",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_sawedoff").Value,
                        Shots = totalShotsSawedOff,
                        Hits = totalHitsSawedOff,
                        Accuracy = Math.Round(totalHitsSawedOff  / totalShotsSawedOff, 2),
                        Type = WeaponType.Shotgun
                    },
                    new Weapon()
                    {
                        Name = "XM1014",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_xm1014").Value,
                        Shots = totalShotsXM1014,
                        Hits = totalHitsXM1014,
                        Accuracy = Math.Round(totalHitsXM1014  / totalShotsXM1014, 2),
                        Type = WeaponType.Shotgun
                    },
                    new Weapon()
                    {
                        Name = "Desert Eagle",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_deagle").Value,
                        Shots = totalShotsDesertEagle,
                        Hits = totalHitsDesertEagle,
                        Accuracy = Math.Round(totalHitsDesertEagle  / totalShotsDesertEagle, 2),
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "Dual Berettas",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_elite").Value,
                        Shots = totalShotsDualBerettas,
                        Hits = totalHitsDualBerettas,
                        Accuracy = Math.Round(totalHitsDualBerettas  / totalShotsDualBerettas, 2),
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "Five-SeveN",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_fiveseven").Value,
                        Shots = totalShotsFiveSeveN,
                        Hits = totalHitsFiveSeveN,
                        Accuracy = Math.Round(totalHitsFiveSeveN  / totalShotsFiveSeveN, 2),
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "Glock-18",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_glock").Value,
                        Shots = totalShotsGlock18,
                        Hits = totalHitsGlock18,
                        Accuracy = Math.Round(totalHitsGlock18  / totalShotsGlock18, 2),
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "USP-S and HKP2000",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_hkp2000").Value,
                        Shots = totalShotsHKP2000,
                        Hits = totalHitsHKP2000,
                        Accuracy = Math.Round(totalHitsHKP2000  / totalShotsHKP2000, 2),
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "P250",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_p250").Value,
                        Shots = totalShotsP250,
                        Hits = totalHitsP250,
                        Accuracy = Math.Round(totalHitsP250  / totalShotsP250, 2),
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "Tec-9",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_tec9").Value,
                        Shots = totalShotsTec9,
                        Hits = totalHitsTec9,
                        Accuracy = Math.Round(totalHitsTec9  / totalShotsTec9, 2),
                        Type = WeaponType.Pistol
                    },
                    new Weapon()
                    {
                        Name = "HE Grenade",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_hegrenade").Value,
                        Shots = null,
                        Hits = null,
                        Accuracy = null,
                        Type = WeaponType.Other
                    },
                    new Weapon()
                    {
                        Name = "Decoy",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_decoy").Value,
                        Shots = null,
                        Hits = null,
                        Accuracy = null,
                        Type = WeaponType.Other
                    },
                    new Weapon()
                    {
                        Name = "Molotov",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_molotov").Value,
                        Shots = null,
                        Hits = null,
                        Accuracy = null,
                        Type = WeaponType.Other
                    },
                    new Weapon()
                    {
                        Name = "Zeus x27",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_taser").Value,
                        Shots = stats.FirstOrDefault(s => s.Name == "total_shots_taser").Value,
                        Hits = null,
                        Accuracy = null,
                        Type = WeaponType.Other
                    },
                    new Weapon()
                    {
                        Name = "Knife",
                        Kills = stats.FirstOrDefault(s => s.Name == "total_kills_knife").Value,
                        Shots = null,
                        Hits = null,
                        Accuracy = null,
                        Type = WeaponType.Melee
                    },
                },
                Maps = new List<Map>
                {
                    new Map()
                    {
                        Name = "de_dust2",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_dust2").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_dust2").Value
                    },
                    new Map()
                    {
                        Name = "de_dust",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_dust").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_dust").Value
                    },
                    new Map()
                    {
                        Name = "cs_assault",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_cs_assault").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_cs_assault").Value
                    },
                    new Map()
                    {
                        Name = "de_aztec",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_aztec").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_aztec").Value
                    },
                    new Map()
                    {
                        Name = "de_cbble",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_cbble").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_cbble").Value
                    },
                    new Map()
                    {
                        Name = "de_inferno",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_inferno").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_inferno").Value
                    },
                    new Map()
                    {
                        Name = "cs_italy",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_cs_italy").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_cs_italy").Value
                    },
                    new Map()
                    {
                        Name = "de_nuke",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_nuke").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_nuke").Value
                    },
                    new Map()
                    {
                        Name = "cs_office",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_cs_office").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_cs_office").Value
                    },
                    new Map()
                    {
                        Name = "de_train",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_train").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_train").Value
                    },
                    new Map()
                    {
                        Name = "de_lake",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_lake").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_lake").Value
                    },
                    new Map()
                    {
                        Name = "de_safehouse",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_safehouse").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_safehouse").Value
                    },
                    new Map()
                    {
                        Name = "de_sugarcane",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_sugarcane").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_sugarcane").Value
                    },
                    new Map()
                    {
                        Name = "de_stmarc",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_stmarc").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_stmarc").Value
                    },
                    new Map()
                    {
                        Name = "de_bank",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_bank").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_bank").Value
                    },
                    new Map()
                    {
                        Name = "de_shorttrain",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_shorttrain").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_shorttrain").Value
                    },
                    new Map()
                    {
                        Name = "ar_shoots",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_ar_shoots").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_ar_shoots").Value
                    },
                    new Map()
                    {
                        Name = "ar_baggage",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_ar_baggage").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_ar_baggage").Value
                    },
                    new Map()
                    {
                        Name = "ar_monastery",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_ar_monastery").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_ar_monastery").Value
                    },
                    new Map()
                    {
                        Name = "de_vertigo",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_de_vertigo").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_de_vertigo").Value
                    },
                    new Map()
                    {
                        Name = "cs_militia",
                        TotalRounds = stats.FirstOrDefault(s => s.Name == "total_rounds_map_cs_militia").Value,
                        TotalWins = stats.FirstOrDefault(s => s.Name == "total_wins_map_cs_militia").Value
                    }
                },
                LastMatch = new LastMatch()
                {
                    CTWins = stats.FirstOrDefault(s => s.Name == "last_match_ct_wins").Value,
                    TWins = stats.FirstOrDefault(s => s.Name == "last_match_t_wins").Value,
                    Wins = stats.FirstOrDefault(s => s.Name == "last_match_wins").Value,
                    Rounds = stats.FirstOrDefault(s => s.Name == "last_match_rounds").Value,
                    MaxPlayers = stats.FirstOrDefault(s => s.Name == "last_match_max_players").Value,
                    Kills = lastMatchKills,
                    Deaths = lastMatchDeaths,
                    KillDeathRatio = Math.Round(lastMatchKills / lastMatchDeaths, 2),
                    Damage = stats.FirstOrDefault(s => s.Name == "last_match_damage").Value,
                    MVPs = stats.FirstOrDefault(s => s.Name == "last_match_mvps").Value,
                    FavoriteWeaponId = stats.FirstOrDefault(s => s.Name == "last_match_favweapon_id").Value,
                    FavoriteWeaponHits = lastMatchFavoriteWeaponHits,
                    FavoriteWeaponShots = lastMatchFavoriteWeaponShots,
                    FavoriteWeaponKills = stats.FirstOrDefault(s => s.Name == "last_match_favweapon_kills").Value,
                    FavoriteWeaponAccuracy = Math.Round(lastMatchFavoriteWeaponHits / lastMatchFavoriteWeaponShots * 100, 2),
                    MoneySpent = stats.FirstOrDefault(s => s.Name == "last_match_money_spent").Value,
                    Dominations = stats.FirstOrDefault(s => s.Name == "last_match_domnations").Value,
                    Revenges = stats.FirstOrDefault(s => s.Name == "last_match_revenges").Value,
                    ContributionScore = stats.FirstOrDefault(s => s.Name == "last_match_contribution_score").Value,
                    GunGameContributionScore = stats.FirstOrDefault(s => s.Name == "last_match_gg_contribution_score").Value
                }
            };
        }
    }
}
