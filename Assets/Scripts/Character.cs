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
        GetPlayerComponents();
        InitializeBattleStatisticOnGameStart();
        UpdateStatisticUI();
    }

    private void InitializeBattleStatisticOnGameStart()
    {
        battleStatistics = new BattleStatistics();
        battleStatistics.basicStatistics = new BasicStatistics(statisticsLevelUpdate.StrenghtMultiplier, statisticsLevelUpdate.VitalityMultiplier, statisticsLevelUpdate.IntelligenceMultiplier, statisticsLevelUpdate.DexterityMultiplier);
        InitializeDuelStatistics(characterInformation._Level);
    }

    private void InitializeDuelStatistics(float level)
    {
        float attackDamage = statisticsLevelUpdate.GetBaseCalculatedAttackDamage(level);
        float armour = statisticsLevelUpdate.GetBaseCalculatedArmour(level);
        float health = statisticsLevelUpdate.GetBaseCalculatedHealth(level);
        float mana = statisticsLevelUpdate.GetBaseCalculatedMana(level);
        battleStatistics.duelStatistics = new DuelStatistics(attackDamage, armour, health, mana);
    }
    public override void UpdateStatisticsBasedOnLevel()
    {
        battleStatistics.basicStatistics.UpdateBaseStrenght(characterInformation._Level, statisticsLevelUpdate.StrenghtMultiplier);
        battleStatistics.basicStatistics.UpdateBaseVitality(characterInformation._Level, statisticsLevelUpdate.VitalityMultiplier);
        battleStatistics.basicStatistics.UpdateBaseIntelligence(characterInformation._Level, statisticsLevelUpdate.IntelligenceMultiplier);
        battleStatistics.basicStatistics.UpdateBaseDexterity(characterInformation._Level, statisticsLevelUpdate.DexterityMultiplier);
        UpdateCurrentStats();
        battleStatistics.duelStatistics.UpdateDuelStatistics(characterInformation._Level, statisticsLevelUpdate);
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
        basicStatsUIView.UpdateLevelText(characterInformation._Level);
        basicStatsUIView.UpdateBasicStatsUI(battleStatistics.basicStatistics);
        duelStatsUIView.SetDuelStatsValuesOnUI(battleStatistics.duelStatistics);
    }

    private void GetPlayerComponents()
    {
        characterInformation = GetComponent<CharacterInformation>();
        battleStatistics = GetComponent<BattleStatistics>();
        statisticsLevelUpdate = GetComponent<StatisticsLevelUpdate>();
        characterUIView = GetComponent<CharacterUIView>();
        basicStatsUIView = GetComponent<BasicStatsUIView>();
        duelStatsUIView = GetComponent<DuelStatsUIView>();
    }


}
