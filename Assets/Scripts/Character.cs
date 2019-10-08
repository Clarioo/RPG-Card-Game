using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Playable
{
    CharacterInformation characterInformation;
    BattleStatistics battleStatistics;
    StatisticsLevelUpdater statisticsLevelUpdater;
    CharacterUIView characterUIView;

    BasicStatsUIView basicStatsUIView;
    DuelStatsUIView duelStatsUIView;
    

    private void Start()
    {
        SetPlayerComponents();
        InitializeBattleStatisticOnGameStart();
    }

    private void InitializeBattleStatisticOnGameStart()
    {
        battleStatistics = new BattleStatistics(statisticsLevelUpdater, characterInformation);
        battleStatistics.InitializeBattleStatisics(basicStatsUIView, duelStatsUIView);
        Debug.Log(battleStatistics);
    }


    public void LevelUp()
    {
        characterInformation.IncreaseLevel();
        battleStatistics.UpdateStatisticsBasedOnLevel();
    }
    public void LevelDown()
    {
        characterInformation.DecreaseLevel();
        battleStatistics.UpdateStatisticsBasedOnLevel();
    }

    private void SetPlayerComponents()
    {
        characterInformation = GetComponent<CharacterInformation>();
        statisticsLevelUpdater = GetComponent<StatisticsLevelUpdater>();
        characterUIView = GetComponent<CharacterUIView>();

        basicStatsUIView = GetComponent<BasicStatsUIView>();
        duelStatsUIView = GetComponent<DuelStatsUIView>();
    }


}
