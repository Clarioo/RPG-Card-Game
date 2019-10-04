using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Playable
{
    CharacterInformation characterInformation;
    BattleStatistics battleStatistics;
    StatisticsLevelUpdate statisticsLevelUpdate;
    CharacterUIView characterUIView;
    BasicStatsUIView basicStatsUIView;
    DuelStatsUIView duelStatsUIView;

    private void Start()
    {
        SetPlayerComponents();
        InitializeBattleStatisticOnGameStart();
        UpdateStatisticUI();
    }

    private void InitializeBattleStatisticOnGameStart()
    {
        battleStatistics = new BattleStatistics();
        battleStatistics.basicStatistics = new BasicStatistics(statisticsLevelUpdate);
        InitializeDuelStatistics();
    }

    private void InitializeDuelStatistics()
    {
        battleStatistics.duelStatistics = new DuelStatistics(statisticsLevelUpdate, characterInformation._Level);
    }
    public void UpdateStatisticsBasedOnLevel()
    {
        battleStatistics.basicStatistics.UpdateStatsBasedOnLevel(characterInformation._Level, statisticsLevelUpdate);
        battleStatistics.basicStatistics.UpdateCurrentStatsBasedOnBaseStats();
        UpdateDuelStats();
    }
    public void UpdateDuelStats()
    {
        battleStatistics.duelStatistics.UpdateDuelStatistics(statisticsLevelUpdate, characterInformation._Level);
    }


    public void LevelUp()
    {
        characterInformation._Level++;
        UpdateStatisticsBasedOnLevel();
        UpdateStatisticUI();
    }
    public void LevelDown()
    {
        characterInformation._Level--;
        UpdateStatisticsBasedOnLevel();
        UpdateStatisticUI();
    }
    private void UpdateStatisticUI()
    {
        basicStatsUIView.UpdateLevelText(characterInformation._Level);
        basicStatsUIView.UpdateBasicStatsUI(battleStatistics.basicStatistics);
        duelStatsUIView.SetDuelStatsValuesOnUI(battleStatistics.duelStatistics);
    }

    private void SetPlayerComponents()
    {
        characterInformation = GetComponent<CharacterInformation>();
        battleStatistics = GetComponent<BattleStatistics>();
        statisticsLevelUpdate = GetComponent<StatisticsLevelUpdate>();
        characterUIView = GetComponent<CharacterUIView>();
        basicStatsUIView = GetComponent<BasicStatsUIView>();
        duelStatsUIView = GetComponent<DuelStatsUIView>();
    }


}
