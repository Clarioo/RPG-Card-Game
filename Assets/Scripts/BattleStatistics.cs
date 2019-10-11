using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStatistics {

    BasicStatistics basicStatistics;
    DuelStatistics duelStatistics;
    ElementalAttackStats elementalAttackStats;
    ElementalDefenseStats ElementalDefenseStats;

    StatisticsLevelUpdater statisticsLevelUpdater;
    CharacterInformation characterInformation;

	public BattleStatistics(StatisticsLevelUpdater statisticsLevelUpdater, CharacterInformation characterInformation)
    {
        this.statisticsLevelUpdater = statisticsLevelUpdater;
        this.characterInformation = characterInformation;
    }

    public void InitializeBattleStatisics(BasicStatsUIView basicStatsUIView, DuelStatsUIView duelStatsUIView)
    {
        basicStatistics = new BasicStatistics(statisticsLevelUpdater, basicStatsUIView);
        duelStatistics = new DuelStatistics(statisticsLevelUpdater, characterInformation._Level, duelStatsUIView);
    }
    public void UpdateStatisticsBasedOnLevel()
    {
        basicStatistics.UpdateStatsBasedOnLevel(characterInformation._Level, statisticsLevelUpdater);
        basicStatistics.UpdateCurrentStatsBasedOnBaseStats();
        UpdateDuelStats();
    }
    public void UpdateDuelStats()
    {
        duelStatistics.UpdateDuelStatistics(characterInformation._Level);
    }

    








}
