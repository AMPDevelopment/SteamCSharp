using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SteamCSharp.Entities.Games
{
    public class CounterStrikeGlobalOffensive
    {
        [JsonProperty("total_kills", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKills { get; set; }

        [JsonProperty("total_deaths", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalDeaths { get; set; }

        // Todo: Convert seconds in readable time
        [JsonProperty("total_time_played", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalTimePlayed { get; set; }

        [JsonProperty("total_planted_bombs", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalPlantedBombs { get; set; }

        [JsonProperty("total_defused_bombs", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalDefusedBombs { get; set; }

        [JsonProperty("total_wins", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWins { get; set; }

        [JsonProperty("total_damage_done", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalDamageDone { get; set; }

        [JsonProperty("total_money_earned", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMoneyEarned { get; set; }

        [JsonProperty("total_rescued_hostages", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRescuedHostages { get; set; }

        [JsonProperty("total_kills_knife", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsKnife { get; set; }

        [JsonProperty("total_kills_hegrenade", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsHeGrenade { get; set; }

        [JsonProperty("total_kills_glock", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsGloke { get; set; }

        [JsonProperty("total_kills_deagle", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsDeagle { get; set; }

        [JsonProperty("total_kills_elite", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsDualElite { get; set; }

        [JsonProperty("total_kills_fiveseven", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsFiveSeven { get; set; }

        [JsonProperty("total_kills_xm1014", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsXM1014 { get; set; }

        [JsonProperty("total_kills_mac10", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsMAC10 { get; set; }

        [JsonProperty("total_kills_ump45", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsUMP45 { get; set; }

        [JsonProperty("total_kills_p90", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsP90 { get; set; }

        [JsonProperty("total_kills_awp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsAWP { get; set; }

        [JsonProperty("total_kills_ak47", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsAK47 { get; set; }

        [JsonProperty("total_kills_aug", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsAUG { get; set; }

        [JsonProperty("total_kills_famas", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsFAMAS { get; set; }

        [JsonProperty("total_kills_g3sg1", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsG3SG1 { get; set; }

        [JsonProperty("total_kills_m249", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsM249 { get; set; }

        [JsonProperty("total_kills_headshot", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsHeadshot { get; set; }

        [JsonProperty("total_kills_enemy_weapon", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsEnemyWeapon { get; set; }

        [JsonProperty("total_wins_pistolround", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsPistolRound { get; set; }

        [JsonProperty("total_wins_map_cs_assault", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsAssault { get; set; }

        [JsonProperty("total_wins_map_cs_italy", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsItaly { get; set; }

        [JsonProperty("total_wins_map_cs_office", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsOffice { get; set; }

        [JsonProperty("total_wins_map_de_aztec", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsAztec { get; set; }

        [JsonProperty("total_wins_map_de_cbble", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsCobblestone { get; set; }

        [JsonProperty("total_wins_map_de_dust2", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsDust2 { get; set; }

        [JsonProperty("total_wins_map_de_dust", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsDust { get; set; }

        [JsonProperty("total_wins_map_de_inferno", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsInferno { get; set; }

        [JsonProperty("total_wins_map_de_nuke", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsNuke { get; set; }

        [JsonProperty("total_wins_map_de_train", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsTrain { get; set; }

        [JsonProperty("total_weapons_donated", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWeaponsDonated { get; set; }

        [JsonProperty("total_broken_windows", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalBrokenWindows { get; set; }

        [JsonProperty("total_kills_enemy_blinded", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsEnemyBlinded { get; set; }

        [JsonProperty("total_kills_knife_fight", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsKnifeFight { get; set; }

        [JsonProperty("total_kills_against_zoomed_sniper", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsAgainstZoomedSniper { get; set; }

        [JsonProperty("total_dominations", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalDominations { get; set; }

        [JsonProperty("total_domination_overkills", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalDominationOverkills { get; set; }

        [JsonProperty("total_revenges", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRevenges { get; set; }

        [JsonProperty("total_shots_hit", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsHit { get; set; }

        [JsonProperty("total_shots_fired", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsFired { get; set; }

        [JsonProperty("total_rounds_played", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsPlayed { get; set; }

        [JsonProperty("total_shots_deagle", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsDeagle { get; set; }

        [JsonProperty("total_shots_glock", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsGlock { get; set; }

        [JsonProperty("total_shots_elite", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsDualElite { get; set; }

        [JsonProperty("total_shots_fiveseven", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsFiveSeven { get; set; }

        [JsonProperty("total_shots_awp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsAWP { get; set; }

        [JsonProperty("total_shots_ak47", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsAK47 { get; set; }

        [JsonProperty("total_shots_aug", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsAUG { get; set; }

        [JsonProperty("total_shots_famas", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsFAMAS { get; set; }

        [JsonProperty("total_shots_g3sg1", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsG3SG1 { get; set; }

        [JsonProperty("total_shots_p90", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsP90 { get; set; }

        [JsonProperty("total_shots_mac10", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsMAC10 { get; set; }

        [JsonProperty("total_shots_ump45", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsUMP45 { get; set; }

        [JsonProperty("total_shots_xm1014", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsXM1014 { get; set; }

        [JsonProperty("total_shots_m249", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsM249 { get; set; }

        [JsonProperty("total_hits_deagle", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsDeagle { get; set; }

        [JsonProperty("total_hits_glock", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsGlock { get; set; }

        [JsonProperty("total_hits_elite", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsDualElite { get; set; }

        [JsonProperty("total_hits_fiveseven", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsFiveSeven { get; set; }

        [JsonProperty("total_hits_awp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsAWP { get; set; }

        [JsonProperty("total_hits_ak47", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsAK47 { get; set; }

        [JsonProperty("total_hits_aug", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsAUG { get; set; }

        [JsonProperty("total_hits_famas", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsFAMAS { get; set; }

        [JsonProperty("total_hits_g3sg1", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsG3SG1 { get; set; }

        [JsonProperty("total_hits_p90", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsP90 { get; set; }

        [JsonProperty("total_hits_mac10", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsMAC10 { get; set; }

        [JsonProperty("total_hits_ump45", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsUMP45 { get; set; }

        [JsonProperty("total_hits_xm1014", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsXM1014 { get; set; }

        [JsonProperty("total_hits_m249", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsM249 { get; set; }

        [JsonProperty("total_rounds_map_cs_assault", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsAssault { get; set; }

        [JsonProperty("total_rounds_map_cs_italy", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsItaly { get; set; }

        [JsonProperty("total_rounds_map_cs_office", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsOffice { get; set; }

        [JsonProperty("total_rounds_map_de_aztec", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsAztec { get; set; }

        [JsonProperty("total_rounds_map_de_cbble", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsCobblestone { get; set; }

        [JsonProperty("total_rounds_map_de_dust2", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsDust2 { get; set; }

        [JsonProperty("total_rounds_map_de_dust", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsDust { get; set; }

        [JsonProperty("total_rounds_map_de_inferno", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsInferno { get; set; }

        [JsonProperty("total_rounds_map_de_nuke", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsNuke { get; set; }

        [JsonProperty("total_rounds_map_de_train", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Train { get; set; }

        [JsonProperty("last_match_t_wins", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchTWins { get; set; }

        [JsonProperty("last_match_ct_wins", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchCTWins { get; set; }

        [JsonProperty("last_match_wins", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchWins { get; set; }

        [JsonProperty("last_match_max_players", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchMaxPlayers { get; set; }

        [JsonProperty("last_match_kills", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchKills { get; set; }

        [JsonProperty("last_match_deaths", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchDeaths { get; set; }

        [JsonProperty("last_match_mvps", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchMVPs { get; set; }

        [JsonProperty("last_match_favweapon_id", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchFavoriteWeaponId { get; set; }

        [JsonProperty("last_match_favweapon_shots", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchFavoriteWeaponShots { get; set; }

        [JsonProperty("last_match_favweapon_hits", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchFavoriteWeaponHits { get; set; }

        [JsonProperty("last_match_favweapon_kills", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchFavoriteWeaponKills { get; set; }

        [JsonProperty("last_match_damage", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchDamage { get; set; }

        [JsonProperty("last_match_money_spent", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchMoneySpent { get; set; }

        [JsonProperty("last_match_dominations", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchDominations { get; set; }

        [JsonProperty("last_match_revenges", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchRevenges { get; set; }

        [JsonProperty("total_mvps", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMVPs { get; set; }

        [JsonProperty("total_rounds_map_de_lake", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsLake { get; set; }

        [JsonProperty("total_rounds_map_de_safehouse", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsSafehouse { get; set; }

        [JsonProperty("total_rounds_map_de_sugarcane", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsSugarcane { get; set; }

        [JsonProperty("total_rounds_map_de_stmarc", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsStMarc { get; set; }

        [JsonProperty("total_rounds_map_de_bank", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsBank { get; set; }

        [JsonProperty("total_rounds_map_de_shorttrain", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsStortTrain { get; set; }

        // Todo: Figure the fuck out what TR means.
        [JsonProperty("total_TR_planted_bombs", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalTRPlantedBombs { get; set; }

        // Todo: Figure the fuck out what TR means.
        [JsonProperty("total_TR_defused_bombs", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalTRDefusedBombs { get; set; }

        [JsonProperty("total_gun_game_rounds_won", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalGunGameRoundsWon { get; set; }

        [JsonProperty("total_gun_game_rounds_played", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalGunGameRoundsPlayed { get; set; }

        [JsonProperty("total_wins_map_de_house", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsHouse { get; set; }

        [JsonProperty("total_wins_map_de_bank", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsBank { get; set; }

        [JsonProperty("total_wins_map_de_vertigo", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsVertigo { get; set; }

        [JsonProperty("total_wins_map_ar_monastery", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsMonastery { get; set; }

        [JsonProperty("total_rounds_map_ar_shoots", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsShoots { get; set; }

        [JsonProperty("total_rounds_map_ar_baggage", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsBaggage { get; set; }

        [JsonProperty("total_wins_map_ar_shoots", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsShoots { get; set; }

        [JsonProperty("total_wins_map_ar_baggage", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsBaggage { get; set; }

        [JsonProperty("total_wins_map_de_lake", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsLake { get; set; }

        [JsonProperty("total_wins_map_de_sugarcane", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsSugarcane { get; set; }

        [JsonProperty("total_wins_map_de_stmarc", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsStMarc { get; set; }

        [JsonProperty("total_matches_won_bank", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonBank { get; set; }

        [JsonProperty("total_wins_map_de_shorttrain", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsShortTrain { get; set; }

        [JsonProperty("total_wins_map_de_safehouse", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsSafehouse { get; set; }

        [JsonProperty("total_matches_won", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWon { get; set; }

        [JsonProperty("total_matches_played", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesPlayed { get; set; }

        [JsonProperty("total_gg_matches_won", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalGunGameMatchesWon { get; set; }

        [JsonProperty("total_gg_matches_played", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalGunGameMatchesPlayed { get; set; }

        // Todo: Figure the fuck out what progressive matches means.
        [JsonProperty("total_progressive_matches_won", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalProgressiveMatchesWon { get; set; }

        // Todo: Figure the fuck out what TR means.
        [JsonProperty("total_trbomb_matches_won", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalTRBombMatchesWon { get; set; }

        [JsonProperty("total_contribution_score", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalContributionScore { get; set; }

        [JsonProperty("last_match_contribution_score", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchContributionScore { get; set; }

        [JsonProperty("last_match_rounds", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchRounds { get; set; }

        [JsonProperty("total_kills_hkp2000", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsHKP2000 { get; set; }

        [JsonProperty("total_shots_hkp2000", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsHKP2000 { get; set; }

        [JsonProperty("total_hits_hkp2000", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsHKP2000 { get; set; }

        [JsonProperty("total_hits_p250", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsP250 { get; set; }

        [JsonProperty("total_kills_p250", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsP250 { get; set; }

        [JsonProperty("total_shots_p250", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsP250 { get; set; }

        [JsonProperty("total_kills_sg556", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsSG556 { get; set; }

        [JsonProperty("total_shots_sg556", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsSG556 { get; set; }

        [JsonProperty("total_hits_sg556", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsSG556 { get; set; }

        [JsonProperty("total_hits_scar20", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsSCAR20 { get; set; }

        [JsonProperty("total_kills_scar20", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsSCAR20 { get; set; }

        [JsonProperty("total_shots_scar20", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsSCAR20 { get; set; }

        [JsonProperty("total_shots_ssg08", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsSSG08 { get; set; }

        [JsonProperty("total_hits_ssg08", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsSSG08 { get; set; }

        [JsonProperty("total_kills_ssg08", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsSSG08 { get; set; }

        [JsonProperty("total_shots_mp7", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsMP7 { get; set; }

        [JsonProperty("total_hits_mp7", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsMP7 { get; set; }

        [JsonProperty("total_kills_mp7", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsMP7 { get; set; }

        [JsonProperty("total_kills_mp9", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsMP9 { get; set; }

        [JsonProperty("total_shots_mp9", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsMP9 { get; set; }

        [JsonProperty("total_hits_mp9", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsMP9 { get; set; }

        [JsonProperty("total_hits_nova", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsNova { get; set; }

        [JsonProperty("total_kills_nova", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsNova { get; set; }

        [JsonProperty("total_shots_nova", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsNova { get; set; }

        [JsonProperty("total_hits_negev", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsNegev { get; set; }

        [JsonProperty("total_kills_negev", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsNegev { get; set; }

        [JsonProperty("total_shots_negev", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsNegev { get; set; }

        [JsonProperty("total_shots_sawedoff", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsSawedOff { get; set; }

        [JsonProperty("total_hits_sawedoff", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsSawedOff { get; set; }

        [JsonProperty("total_kills_sawedoff", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsSawedOff { get; set; }

        [JsonProperty("total_shots_bizon", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsPPBizon { get; set; }

        [JsonProperty("total_hits_bizon", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsPPBizon { get; set; }

        [JsonProperty("total_kills_bizon", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsPPBizon { get; set; }

        [JsonProperty("total_kills_tec9", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsTec9 { get; set; }

        [JsonProperty("total_shots_tec9", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsTec9 { get; set; }

        [JsonProperty("total_hits_tec9", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsTec9 { get; set; }

        [JsonProperty("total_shots_mag7", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalTotalMAG7Kills { get; set; }

        [JsonProperty("total_hits_mag7", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsMAG7 { get; set; }

        [JsonProperty("total_kills_mag7", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsMAG7 { get; set; }

        [JsonProperty("total_gun_game_contribution_score", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalGunGameContributionScore { get; set; }

        [JsonProperty("last_match_gg_contribution_score", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMatchGunGameContributionScore { get; set; }

        [JsonProperty("total_kills_m4a1", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsM4A1 { get; set; }

        [JsonProperty("total_kills_galilar", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsGalilAR { get; set; }

        [JsonProperty("total_kills_molotov", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsMolotov { get; set; }

        [JsonProperty("total_kills_decoy", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsDecoy { get; set; }

        [JsonProperty("total_kills_taser", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalKillsTaser { get; set; }

        [JsonProperty("total_shots_m4a1", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsM4A1 { get; set; }

        [JsonProperty("total_shots_galilar", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsGalilAR { get; set; }

        [JsonProperty("total_shots_taser", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalShotsTaser { get; set; }

        [JsonProperty("total_hits_m4a1", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsM4A1 { get; set; }

        [JsonProperty("total_hits_galilar", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalHitsGalilAR { get; set; }

        [JsonProperty("total_rounds_map_ar_monastery", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsMonastery { get; set; }

        [JsonProperty("total_matches_won_train", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonTrain { get; set; }

        [JsonProperty("total_rounds_map_de_vertigo", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsVertigo { get; set; }

        [JsonProperty("total_matches_won_shoots", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonShoots { get; set; }

        [JsonProperty("total_matches_won_baggage", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonBaggage { get; set; }

        [JsonProperty("total_matches_won_lake", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonLake { get; set; }

        [JsonProperty("total_matches_won_sugarcane", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonSugarcane { get; set; }

        [JsonProperty("total_matches_won_stmarc", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonStMarc { get; set; }

        [JsonProperty("total_matches_won_safehouse", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonSafehouse { get; set; }

        [JsonProperty("total_matches_won_shorttrain", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalMatchesWonShortTrain { get; set; }

        // Todo: Figure out how to trigger the amount.
        [JsonProperty("GI.lesson.csgo_instr_explain_bomb_carrier", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LessonInstructorExplainBombCarrier { get; set; }

        // Todo: Figure out how to trigger the amount.
        [JsonProperty("GI.lesson.defuse_planted_bomb", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LessonDefusePlantedBomb { get; set; }

        [JsonProperty("GI.lesson.version_number", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LessonVersionNumber { get; set; }

        [JsonProperty("total_wins_map_cs_militia", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalWinsMilitia { get; set; }

        [JsonProperty("total_rounds_map_cs_militia", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalRoundsMilitia { get; set; }

        [JsonProperty("GI.lesson.csgo_instr_explain_inspect", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LessonInstructorExplainInspect { get; set; }

        [JsonProperty("steam_stat_xpearnedgames", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SteamStatXpEarnedGames { get; set; }
    }
}
