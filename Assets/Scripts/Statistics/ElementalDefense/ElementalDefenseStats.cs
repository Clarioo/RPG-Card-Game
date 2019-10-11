using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalDefenseStats
{
    public FireDefense FireDefense { get; private set; }
    public WaterDefense WaterDefense { get; private set; }
    public ElectroDefense ElectroDefense { get; private set; }
    public PoisonDefense PoisonDefense { get; private set; }

    StatisticsLevelUpdater statisticsLevelUpdater;
    ElementalStatsUIView elementalStatsUIView;

    public ElementalDefenseStats(StatisticsLevelUpdater statisticsLevelUpdater, ElementalStatsUIView elementalStatsUIView)
    {
        this.statisticsLevelUpdater = statisticsLevelUpdater;
        this.elementalStatsUIView = elementalStatsUIView;
        CreateElementalDefenseStats();
    }

    private void CreateElementalDefenseStats()
    {
        FireDefense = new FireDefense(statisticsLevelUpdater.FireDefenseMultiplier);
        WaterDefense = new WaterDefense(statisticsLevelUpdater.WaterDefenseMultiplier);
        ElectroDefense = new ElectroDefense(statisticsLevelUpdater.ElectroDefenseMultiplier);
        PoisonDefense = new PoisonDefense(statisticsLevelUpdater.PoisonDefenseMultiplier);
        elementalStatsUIView.SetElementalDefenseValuesOnUI(this);
    }
    public void UpdateStatsBasedOnLevel(float level)
    {
        FireDefense.UpdateBaseValue(level, statisticsLevelUpdater.FireDefenseMultiplier);
        WaterDefense.UpdateBaseValue(level, statisticsLevelUpdater.WaterDefenseMultiplier);
        ElectroDefense.UpdateBaseValue(level, statisticsLevelUpdater.ElectroDefenseMultiplier);
        PoisonDefense.UpdateBaseValue(level, statisticsLevelUpdater.PoisonDefenseMultiplier);
        UpdateCurrentStatsBasedOnBaseStats();
        elementalStatsUIView.SetElementalDefenseValuesOnUI(this);
    }
    private void UpdateCurrentStatsBasedOnBaseStats()
    {
        FireDefense.CurrentValue = FireDefense.GetBaseValue();
        WaterDefense.CurrentValue = WaterDefense.GetBaseValue();
        ElectroDefense.CurrentValue = ElectroDefense.GetBaseValue();
        PoisonDefense.CurrentValue = PoisonDefense.GetBaseValue();
    }
   
}

