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
        battleStatistics = new BattleStatistics();
        battleStatistics.basicStatistics = new BasicStatistics(statisticsLevelUpdate.StrenghtMultiplier, statisticsLevelUpdate.VitalityMultiplier, statisticsLevelUpdate.IntelligenceMultiplier, statisticsLevelUpdate.DexterityMultiplier);
    }

    public override void UpdateStatisticsBasedOnLevel()
    {
        battleStatistics.basicStatistics.UpdateBaseStrenght(characterInformation._Level, statisticsLevelUpdate.StrenghtMultiplier);
        battleStatistics.basicStatistics.UpdateBaseVitality(characterInformation._Level, statisticsLevelUpdate.VitalityMultiplier);
        battleStatistics.basicStatistics.UpdateBaseIntelligence(characterInformation._Level, statisticsLevelUpdate.IntelligenceMultiplier);
        battleStatistics.basicStatistics.UpdateBaseDexterity(characterInformation._Level, statisticsLevelUpdate.DexterityMultiplier);
        UpdateCurrentStats();
    }
    private void UpdateCurrentStats()
    {
        battleStatistics.basicStatistics.UpdateCurrentStatsBasedOnBaseStats();
    }
    public override void LevelUp()
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
        float strenghtCurr = battleStatistics.basicStatistics.strenght.GetCurrentValue();
        float vitalityCurr = battleStatistics.basicStatistics.vitality.GetCurrentValue();
        float intelligenceCurr = battleStatistics.basicStatistics.intelligence.GetCurrentValue();
        float dexterityCurr = battleStatistics.basicStatistics.dexterity.GetCurrentValue();
        characterUIView.UpdateLevelText(characterInformation._Level);
        characterUIView.UpdateBasicStatsUI(strenghtCurr, vitalityCurr, intelligenceCurr, dexterityCurr);
    }

    private void GetPlayerComponents()
    {
        characterInformation = GetComponent<CharacterInformation>();
        battleStatistics = GetComponent<BattleStatistics>();
        statisticsLevelUpdate = GetComponent<StatisticsLevelUpdate>();
        characterUIView = GetComponent<CharacterUIView>();
    }


}
