using Newtonsoft.Json;

namespace SteamCSharp.Entities.Games
{
    public class CounterStrikeGlobalOffensiveDto
    {
        [JsonProperty("total_kills", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKills { get; set; }

        [JsonProperty("total_deaths", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalDeaths { get; set; }

        // Todo: Convert seconds in readable time
        [JsonProperty("total_time_played", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTimePlayed { get; set; }

        [JsonProperty("total_planted_bombs", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalPlantedBombs { get; set; }

        [JsonProperty("total_defused_bombs", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalDefusedBombs { get; set; }

        [JsonProperty("total_wins", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWins { get; set; }

        [JsonProperty("total_damage_done", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalDamageDone { get; set; }

        [JsonProperty("total_money_earned", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMoneyEarned { get; set; }

        [JsonProperty("total_rescued_hostages", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRescuedHostages { get; set; }

        [JsonProperty("total_kills_knife", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsKnife { get; set; }

        [JsonProperty("total_kills_hegrenade", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsHeGrenade { get; set; }

        [JsonProperty("total_kills_glock", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsGlock { get; set; }

        [JsonProperty("total_kills_deagle", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsDeagle { get; set; }

        [JsonProperty("total_kills_elite", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsDualElite { get; set; }

        [JsonProperty("total_kills_fiveseven", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsFiveSeven { get; set; }

        [JsonProperty("total_kills_xm1014", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsXM1014 { get; set; }

        [JsonProperty("total_kills_mac10", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsMAC10 { get; set; }

        [JsonProperty("total_kills_ump45", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsUMP45 { get; set; }

        [JsonProperty("total_kills_p90", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsP90 { get; set; }

        [JsonProperty("total_kills_awp", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsAWP { get; set; }

        [JsonProperty("total_kills_ak47", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsAK47 { get; set; }

        [JsonProperty("total_kills_aug", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsAUG { get; set; }

        [JsonProperty("total_kills_famas", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsFAMAS { get; set; }

        [JsonProperty("total_kills_g3sg1", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsG3SG1 { get; set; }

        [JsonProperty("total_kills_m249", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsM249 { get; set; }

        [JsonProperty("total_kills_headshot", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsHeadshot { get; set; }

        [JsonProperty("total_kills_enemy_weapon", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsEnemyWeapon { get; set; }

        [JsonProperty("total_wins_pistolround", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsPistolRound { get; set; }

        [JsonProperty("total_wins_map_cs_assault", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsAssault { get; set; }

        [JsonProperty("total_wins_map_cs_italy", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsItaly { get; set; }

        [JsonProperty("total_wins_map_cs_office", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsOffice { get; set; }

        [JsonProperty("total_wins_map_de_aztec", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsAztec { get; set; }

        [JsonProperty("total_wins_map_de_cbble", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsCobblestone { get; set; }

        [JsonProperty("total_wins_map_de_dust2", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsDust2 { get; set; }

        [JsonProperty("total_wins_map_de_dust", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsDust { get; set; }

        [JsonProperty("total_wins_map_de_inferno", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsInferno { get; set; }

        [JsonProperty("total_wins_map_de_nuke", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsNuke { get; set; }

        [JsonProperty("total_wins_map_de_train", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsTrain { get; set; }

        [JsonProperty("total_weapons_donated", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWeaponsDonated { get; set; }

        [JsonProperty("total_broken_windows", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalBrokenWindows { get; set; }

        [JsonProperty("total_kills_enemy_blinded", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsEnemyBlinded { get; set; }

        [JsonProperty("total_kills_knife_fight", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsKnifeFight { get; set; }

        [JsonProperty("total_kills_against_zoomed_sniper", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsAgainstZoomedSniper { get; set; }

        [JsonProperty("total_dominations", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalDominations { get; set; }

        [JsonProperty("total_domination_overkills", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalDominationOverkills { get; set; }

        [JsonProperty("total_revenges", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRevenges { get; set; }

        [JsonProperty("total_shots_hit", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsHit { get; set; }

        [JsonProperty("total_shots_fired", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsFired { get; set; }

        [JsonProperty("total_rounds_played", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsPlayed { get; set; }

        [JsonProperty("total_shots_deagle", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsDeagle { get; set; }

        [JsonProperty("total_shots_glock", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsGlock { get; set; }

        [JsonProperty("total_shots_elite", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsDualElite { get; set; }

        [JsonProperty("total_shots_fiveseven", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsFiveSeven { get; set; }

        [JsonProperty("total_shots_awp", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsAWP { get; set; }

        [JsonProperty("total_shots_ak47", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsAK47 { get; set; }

        [JsonProperty("total_shots_aug", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsAUG { get; set; }

        [JsonProperty("total_shots_famas", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsFAMAS { get; set; }

        [JsonProperty("total_shots_g3sg1", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsG3SG1 { get; set; }

        [JsonProperty("total_shots_p90", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsP90 { get; set; }

        [JsonProperty("total_shots_mac10", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsMAC10 { get; set; }

        [JsonProperty("total_shots_ump45", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsUMP45 { get; set; }

        [JsonProperty("total_shots_xm1014", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsXM1014 { get; set; }

        [JsonProperty("total_shots_m249", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsM249 { get; set; }

        [JsonProperty("total_hits_deagle", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsDeagle { get; set; }

        [JsonProperty("total_hits_glock", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsGlock { get; set; }

        [JsonProperty("total_hits_elite", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsDualElite { get; set; }

        [JsonProperty("total_hits_fiveseven", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsFiveSeven { get; set; }

        [JsonProperty("total_hits_awp", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsAWP { get; set; }

        [JsonProperty("total_hits_ak47", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsAK47 { get; set; }

        [JsonProperty("total_hits_aug", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsAUG { get; set; }

        [JsonProperty("total_hits_famas", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsFAMAS { get; set; }

        [JsonProperty("total_hits_g3sg1", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsG3SG1 { get; set; }

        [JsonProperty("total_hits_p90", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsP90 { get; set; }

        [JsonProperty("total_hits_mac10", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsMAC10 { get; set; }

        [JsonProperty("total_hits_ump45", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsUMP45 { get; set; }

        [JsonProperty("total_hits_xm1014", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsXM1014 { get; set; }

        [JsonProperty("total_hits_m249", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsM249 { get; set; }

        [JsonProperty("total_rounds_map_cs_assault", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsAssault { get; set; }

        [JsonProperty("total_rounds_map_cs_italy", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsItaly { get; set; }

        [JsonProperty("total_rounds_map_cs_office", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsOffice { get; set; }

        [JsonProperty("total_rounds_map_de_aztec", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsAztec { get; set; }

        [JsonProperty("total_rounds_map_de_cbble", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsCobblestone { get; set; }

        [JsonProperty("total_rounds_map_de_dust2", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsDust2 { get; set; }

        [JsonProperty("total_rounds_map_de_dust", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsDust { get; set; }

        [JsonProperty("total_rounds_map_de_inferno", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsInferno { get; set; }

        [JsonProperty("total_rounds_map_de_nuke", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsNuke { get; set; }

        [JsonProperty("total_rounds_map_de_train", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsTrain { get; set; }

        [JsonProperty("last_match_t_wins", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchTWins { get; set; }

        [JsonProperty("last_match_ct_wins", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchCTWins { get; set; }

        [JsonProperty("last_match_wins", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchWins { get; set; }

        [JsonProperty("last_match_max_players", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchMaxPlayers { get; set; }

        [JsonProperty("last_match_kills", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchKills { get; set; }

        [JsonProperty("last_match_deaths", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchDeaths { get; set; }

        [JsonProperty("last_match_mvps", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchMVPs { get; set; }

        [JsonProperty("last_match_favweapon_id", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchFavoriteWeaponId { get; set; }

        [JsonProperty("last_match_favweapon_shots", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchFavoriteWeaponShots { get; set; }

        [JsonProperty("last_match_favweapon_hits", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchFavoriteWeaponHits { get; set; }

        [JsonProperty("last_match_favweapon_kills", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchFavoriteWeaponKills { get; set; }

        [JsonProperty("last_match_damage", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchDamage { get; set; }

        [JsonProperty("last_match_money_spent", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchMoneySpent { get; set; }

        [JsonProperty("last_match_dominations", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchDominations { get; set; }

        [JsonProperty("last_match_revenges", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchRevenges { get; set; }

        [JsonProperty("total_mvps", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMVPs { get; set; }

        [JsonProperty("total_rounds_map_de_lake", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsLake { get; set; }

        [JsonProperty("total_rounds_map_de_safehouse", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsSafehouse { get; set; }

        [JsonProperty("total_rounds_map_de_sugarcane", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsSugarcane { get; set; }

        [JsonProperty("total_rounds_map_de_stmarc", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsStMarc { get; set; }

        [JsonProperty("total_rounds_map_de_bank", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsBank { get; set; }

        [JsonProperty("total_rounds_map_de_shorttrain", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsShortTrain { get; set; }

        // Todo: Figure the fuck out what TR means.
        [JsonProperty("total_TR_planted_bombs", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTRPlantedBombs { get; set; }

        // Todo: Figure the fuck out what TR means.
        [JsonProperty("total_TR_defused_bombs", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTRDefusedBombs { get; set; }

        [JsonProperty("total_gun_game_rounds_won", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalGunGameRoundsWon { get; set; }

        [JsonProperty("total_gun_game_rounds_played", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalGunGameRoundsPlayed { get; set; }

        [JsonProperty("total_wins_map_de_house", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsHouse { get; set; }

        [JsonProperty("total_wins_map_de_bank", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsBank { get; set; }

        [JsonProperty("total_wins_map_de_vertigo", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsVertigo { get; set; }

        [JsonProperty("total_wins_map_ar_monastery", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsMonastery { get; set; }

        [JsonProperty("total_rounds_map_ar_shoots", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsShoots { get; set; }

        [JsonProperty("total_rounds_map_ar_baggage", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsBaggage { get; set; }

        [JsonProperty("total_wins_map_ar_shoots", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsShoots { get; set; }

        [JsonProperty("total_wins_map_ar_baggage", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsBaggage { get; set; }

        [JsonProperty("total_wins_map_de_lake", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsLake { get; set; }

        [JsonProperty("total_wins_map_de_sugarcane", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsSugarcane { get; set; }

        [JsonProperty("total_wins_map_de_stmarc", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsStMarc { get; set; }

        [JsonProperty("total_matches_won_bank", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonBank { get; set; }

        [JsonProperty("total_wins_map_de_shorttrain", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsShortTrain { get; set; }

        [JsonProperty("total_wins_map_de_safehouse", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsSafehouse { get; set; }

        [JsonProperty("total_matches_won", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWon { get; set; }

        [JsonProperty("total_matches_played", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesPlayed { get; set; }

        [JsonProperty("total_gg_matches_won", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalGunGameMatchesWon { get; set; }

        [JsonProperty("total_gg_matches_played", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalGunGameMatchesPlayed { get; set; }

        // Todo: Figure the fuck out what progressive matches means.
        [JsonProperty("total_progressive_matches_won", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalProgressiveMatchesWon { get; set; }

        // Todo: Figure the fuck out what TR means.
        [JsonProperty("total_trbomb_matches_won", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTRBombMatchesWon { get; set; }

        [JsonProperty("total_contribution_score", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalContributionScore { get; set; }

        [JsonProperty("last_match_contribution_score", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchContributionScore { get; set; }

        [JsonProperty("last_match_rounds", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchRounds { get; set; }

        [JsonProperty("total_kills_hkp2000", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsHKP2000 { get; set; }

        [JsonProperty("total_shots_hkp2000", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsHKP2000 { get; set; }

        [JsonProperty("total_hits_hkp2000", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsHKP2000 { get; set; }

        [JsonProperty("total_hits_p250", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsP250 { get; set; }

        [JsonProperty("total_kills_p250", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsP250 { get; set; }

        [JsonProperty("total_shots_p250", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsP250 { get; set; }

        [JsonProperty("total_kills_sg556", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsSG553 { get; set; }

        [JsonProperty("total_shots_sg556", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsSG553 { get; set; }

        [JsonProperty("total_hits_sg556", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsSG553 { get; set; }

        [JsonProperty("total_hits_scar20", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsSCAR20 { get; set; }

        [JsonProperty("total_kills_scar20", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsSCAR20 { get; set; }

        [JsonProperty("total_shots_scar20", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsSCAR20 { get; set; }

        [JsonProperty("total_shots_ssg08", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsSSG08 { get; set; }

        [JsonProperty("total_hits_ssg08", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsSSG08 { get; set; }

        [JsonProperty("total_kills_ssg08", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsSSG08 { get; set; }

        [JsonProperty("total_shots_mp7", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsMP7 { get; set; }

        [JsonProperty("total_hits_mp7", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsMP7 { get; set; }

        [JsonProperty("total_kills_mp7", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsMP7 { get; set; }

        [JsonProperty("total_kills_mp9", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsMP9 { get; set; }

        [JsonProperty("total_shots_mp9", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsMP9 { get; set; }

        [JsonProperty("total_hits_mp9", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsMP9 { get; set; }

        [JsonProperty("total_hits_nova", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsNova { get; set; }

        [JsonProperty("total_kills_nova", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsNova { get; set; }

        [JsonProperty("total_shots_nova", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsNova { get; set; }

        [JsonProperty("total_hits_negev", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsNegev { get; set; }

        [JsonProperty("total_kills_negev", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsNegev { get; set; }

        [JsonProperty("total_shots_negev", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsNegev { get; set; }

        [JsonProperty("total_shots_sawedoff", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsSawedOff { get; set; }

        [JsonProperty("total_hits_sawedoff", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsSawedOff { get; set; }

        [JsonProperty("total_kills_sawedoff", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsSawedOff { get; set; }

        [JsonProperty("total_shots_bizon", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsPPBizon { get; set; }

        [JsonProperty("total_hits_bizon", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsPPBizon { get; set; }

        [JsonProperty("total_kills_bizon", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsPPBizon { get; set; }

        [JsonProperty("total_kills_tec9", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsTec9 { get; set; }

        [JsonProperty("total_shots_tec9", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsTec9 { get; set; }

        [JsonProperty("total_hits_tec9", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsTec9 { get; set; }

        [JsonProperty("total_shots_mag7", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsMAG7 { get; set; }

        [JsonProperty("total_hits_mag7", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsMAG7 { get; set; }

        [JsonProperty("total_kills_mag7", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsMAG7 { get; set; }

        [JsonProperty("total_gun_game_contribution_score", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalGunGameContributionScore { get; set; }

        [JsonProperty("last_match_gg_contribution_score", NullValueHandling = NullValueHandling.Ignore)]
        public int LastMatchGunGameContributionScore { get; set; }

        [JsonProperty("total_kills_m4a1", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsM4A1 { get; set; }

        [JsonProperty("total_kills_galilar", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsGalilAR { get; set; }

        [JsonProperty("total_kills_molotov", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsMolotov { get; set; }

        [JsonProperty("total_kills_decoy", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsDecoy { get; set; }

        [JsonProperty("total_kills_taser", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalKillsTaser { get; set; }

        [JsonProperty("total_shots_m4a1", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsM4A1 { get; set; }

        [JsonProperty("total_shots_galilar", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsGalilAR { get; set; }

        [JsonProperty("total_shots_taser", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalShotsTaser { get; set; }

        [JsonProperty("total_hits_m4a1", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsM4A1 { get; set; }

        [JsonProperty("total_hits_galilar", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalHitsGalilAR { get; set; }

        [JsonProperty("total_rounds_map_ar_monastery", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsMonastery { get; set; }

        [JsonProperty("total_matches_won_train", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonTrain { get; set; }

        [JsonProperty("total_rounds_map_de_vertigo", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsVertigo { get; set; }

        [JsonProperty("total_matches_won_shoots", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonShoots { get; set; }

        [JsonProperty("total_matches_won_baggage", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonBaggage { get; set; }

        [JsonProperty("total_matches_won_lake", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonLake { get; set; }

        [JsonProperty("total_matches_won_sugarcane", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonSugarcane { get; set; }

        [JsonProperty("total_matches_won_stmarc", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonStMarc { get; set; }

        [JsonProperty("total_matches_won_safehouse", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonSafehouse { get; set; }

        [JsonProperty("total_matches_won_shorttrain", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalMatchesWonShortTrain { get; set; }

        // Todo: Figure out how to trigger the amount.
        [JsonProperty("GI.lesson.csgo_instr_explain_bomb_carrier", NullValueHandling = NullValueHandling.Ignore)]
        public int LessonInstructorExplainBombCarrier { get; set; }

        // Todo: Figure out how to trigger the amount.
        [JsonProperty("GI.lesson.defuse_planted_bomb", NullValueHandling = NullValueHandling.Ignore)]
        public int LessonDefusePlantedBomb { get; set; }

        [JsonProperty("GI.lesson.version_number", NullValueHandling = NullValueHandling.Ignore)]
        public int LessonVersionNumber { get; set; }

        [JsonProperty("total_wins_map_cs_militia", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWinsMilitia { get; set; }

        [JsonProperty("total_rounds_map_cs_militia", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalRoundsMilitia { get; set; }

        [JsonProperty("GI.lesson.csgo_instr_explain_inspect", NullValueHandling = NullValueHandling.Ignore)]
        public int LessonInstructorExplainInspect { get; set; }

        [JsonProperty("steam_stat_xpearnedgames", NullValueHandling = NullValueHandling.Ignore)]
        public int SteamStatXpEarnedGames { get; set; }
    }
}
