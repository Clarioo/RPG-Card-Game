using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStatistics {

    BasicStatistics basicStatistics;
    DuelStatistics duelStatistics;
    ElementalAttackStats elementalAttackStats;
    ElementalDefenseStats elementalDefenseStats;

    StatisticsLevelUpdater statisticsLevelUpdater;
    CharacterInformation characterInformation;

	public BattleStatistics(StatisticsLevelUpdater statisticsLevelUpdater, CharacterInformation characterInformation)
    {
        this.statisticsLevelUpdater = statisticsLevelUpdater;
        this.characterInformation = characterInformation;
    }

    public void InitializeBattleStatisics(BasicStatsUIView basicStatsUIView, DuelStatsUIView duelStatsUIView, ElementalStatsUIView elementalStatsUIView)
    {
        basicStatistics = new BasicStatistics(statisticsLevelUpdater, basicStatsUIView);
        duelStatistics = new DuelStatistics(statisticsLevelUpdater, characterInformation._Level, duelStatsUIView);
        elementalAttackStats = new ElementalAttackStats(statisticsLevelUpdater, elementalStatsUIView);
        elementalDefenseStats = new ElementalDefenseStats(statisticsLevelUpdater, elementalStatsUIView);
    }
    public void UpdateStatisticsBasedOnLevel()
    {
        basicStatistics.UpdateStatsBasedOnLevel(characterInformation._Level, statisticsLevelUpdater);
        basicStatistics.UpdateCurrentStatsBasedOnBaseStats();
        UpdateDuelStats();
        UpdateElementalAttackStats();
        UpdateElementalDefenseStats();
    }
    public void UpdateDuelStats()
    {
        duelStatistics.UpdateDuelStatistics(characterInformation._Level);
    }
    public void UpdateElementalAttackStats()
    {
        elementalAttackStats.UpdateStatsBasedOnLevel(characterInformation._Level);
    }
    public void UpdateElementalDefenseStats()
    {
        elementalDefenseStats.UpdateStatsBasedOnLevel(characterInformation._Level);
    }

    








}
