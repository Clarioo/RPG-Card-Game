using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalAttackStats
{
    public FireAttack FireAttack { get; private set; }
    public WaterAttack WaterAttack { get; private set; }
    public ElectroAttack ElectroAttack { get; private set; }
    public PoisonAttack PoisonAttack { get; private set; }

    StatisticsLevelUpdater statisticsLevelUpdater;
    ElementalStatsUIView elementalStatsUIView;

    public ElementalAttackStats(StatisticsLevelUpdater statisticsLevelUpdater, ElementalStatsUIView elementalStatsUIView)
    {
        this.statisticsLevelUpdater = statisticsLevelUpdater;
        this.elementalStatsUIView = elementalStatsUIView;
        CreateElementalAttackStats();
    }

    private void CreateElementalAttackStats()
    {
        FireAttack = new FireAttack(statisticsLevelUpdater.FireAttackMultiplier);
        WaterAttack = new WaterAttack(statisticsLevelUpdater.WaterAttackMultiplier);
        ElectroAttack = new ElectroAttack(statisticsLevelUpdater.ElectroAttackMultiplier);
        PoisonAttack = new PoisonAttack(statisticsLevelUpdater.PoisonAttackMultiplier);
        elementalStatsUIView.SetElementalAttackValuesOnUI(this);
    }

    public void UpdateStatsBasedOnLevel(float level)
    {
        FireAttack.UpdateBaseValue(level, statisticsLevelUpdater.FireAttackMultiplier);
        WaterAttack.UpdateBaseValue(level, statisticsLevelUpdater.WaterAttackMultiplier);
        ElectroAttack.UpdateBaseValue(level, statisticsLevelUpdater.ElectroAttackMultiplier);
        PoisonAttack.UpdateBaseValue(level, statisticsLevelUpdater.PoisonAttackMultiplier);
        UpdateCurrentStatsBasedOnBaseStats();
        elementalStatsUIView.SetElementalAttackValuesOnUI(this);
    }
    public void UpdateCurrentStatsBasedOnBaseStats()
    {
        FireAttack.CurrentValue = FireAttack.GetBaseValue();
        WaterAttack.CurrentValue = WaterAttack.GetBaseValue();
        ElectroAttack.CurrentValue = ElectroAttack.GetBaseValue();
        PoisonAttack.CurrentValue = PoisonAttack.GetBaseValue();
    }
}
