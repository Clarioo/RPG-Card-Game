using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Playable
{
    CharacterInformation characterInformation;
    BattleStatistics battleStatistics;
    StatisticsLevelUpdate statisticsLevelUpdate;
    CharacterUIView characterUIView;

    private void Start()
    {
        GetPlayerComponents();
        InitializeBattleStatisticOnGameStart();
        UpdateStatisticUI();
    }

    public override CharacterInformation GetCharacterInformation()
    {
        return characterInformation;
    }

    public override BattleStatistics GetBattleStatistics()
    {
        return battleStatistics;
    }

    private void InitializeBattleStatisticOnGameStart()
    {
        battleStatistics = new BattleStatistics(0, 0, 0, 0);
        UpdateStatisticsBasedOnLevel();
    }

    public override void UpdateStatisticsBasedOnLevel()
    {
        battleStatistics.generalStats["Strenght"].BaseValue = statisticsLevelUpdate.basicBattleStatsLevelMultiplier["Strenght"] * characterInformation._Level;
        battleStatistics.generalStats["Vitality"].BaseValue = statisticsLevelUpdate.basicBattleStatsLevelMultiplier["Vitality"] * characterInformation._Level;
        battleStatistics.generalStats["Intelligence"].BaseValue = statisticsLevelUpdate.basicBattleStatsLevelMultiplier["Intelligence"] * characterInformation._Level;
        battleStatistics.generalStats["Dexterity"].BaseValue = statisticsLevelUpdate.basicBattleStatsLevelMultiplier["Dexterity"] * characterInformation._Level;
        UpdateCurrentStats();
    }
    private void UpdateCurrentStats()
    {
        battleStatistics.generalStats["Strenght"].CurrentValue = battleStatistics.generalStats["Strenght"].BaseValue;
        battleStatistics.generalStats["Vitality"].CurrentValue = battleStatistics.generalStats["Vitality"].BaseValue;
        battleStatistics.generalStats["Intelligence"].CurrentValue = battleStatistics.generalStats["Intelligence"].BaseValue;
        battleStatistics.generalStats["Dexterity"].CurrentValue = battleStatistics.generalStats["Dexterity"].BaseValue;
    }
    public override void LevelUp()
    {
        characterInformation._Level++;
        UpdateStatisticsBasedOnLevel();
        UpdateStatisticUI();
    }
    private void UpdateStatisticUI()
    {
        characterUIView.UpdateLevelText(characterInformation._Level);
        characterUIView.UpdateBasicStatsUI(battleStatistics.generalStats["Strenght"].CurrentValue, battleStatistics.generalStats["Vitality"].CurrentValue, battleStatistics.generalStats["Intelligence"].CurrentValue, battleStatistics.generalStats["Dexterity"].CurrentValue);
    }

    private void GetPlayerComponents()
    {
        characterInformation = GetComponent<CharacterInformation>();
        battleStatistics = GetComponent<BattleStatistics>();
        statisticsLevelUpdate = GetComponent<StatisticsLevelUpdate>();
        characterUIView = GetComponent<CharacterUIView>();
    }


}
