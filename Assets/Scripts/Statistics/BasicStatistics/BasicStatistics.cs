﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStatistics 
{
    Strenght strenght;
    Vitality vitality;
    Intelligence intelligence;
    Dexterity dexterity;

    public Strenght Strenght { get { return strenght; } set { strenght = value; } }
    public Vitality Vitality { get { return vitality; } set { vitality = value; } }
    public Intelligence Intelligence { get { return intelligence; } set { intelligence = value; } }
    public Dexterity Dexterity { get { return dexterity; } set { dexterity = value; } }

    StatisticsLevelUpdater statisticsLevelUpdater;
    BasicStatsUIView basicStatsUIView;

    public BasicStatistics(StatisticsLevelUpdater statisticsLevelUpdater, BasicStatsUIView basicStatsUIView)
    {
        this.statisticsLevelUpdater = statisticsLevelUpdater;
        this.basicStatsUIView = basicStatsUIView;
        CreateBasicStats();
    }

    private void CreateBasicStats()
    {
        strenght = new Strenght(statisticsLevelUpdater.StrenghtMultiplier);
        vitality = new Vitality(statisticsLevelUpdater.VitalityMultiplier);
        intelligence = new Intelligence(statisticsLevelUpdater.IntelligenceMultiplier);
        dexterity = new Dexterity(statisticsLevelUpdater.DexterityMultiplier);
    }
    public void UpdateStatsBasedOnLevel(float level, StatisticsLevelUpdater statisticsLevelUpdate)
    {
        Strenght.UpdateBaseValue(level, statisticsLevelUpdate.StrenghtMultiplier);
        Vitality.UpdateBaseValue(level, statisticsLevelUpdate.VitalityMultiplier);
        Intelligence.UpdateBaseValue(level, statisticsLevelUpdate.IntelligenceMultiplier);
        Dexterity.UpdateBaseValue(level, statisticsLevelUpdate.DexterityMultiplier);
        UpdateCurrentStatsBasedOnBaseStats();
        basicStatsUIView.UpdateBasicStatsUI(this);
    }
    public void UpdateCurrentStatsBasedOnBaseStats()
    {
        Strenght.CurrentValue = Strenght.GetBaseValue();
        Vitality.CurrentValue = Vitality.GetBaseValue();
        Intelligence.CurrentValue = Intelligence.GetBaseValue();
        Dexterity.CurrentValue = Dexterity.GetBaseValue();
    }

    


}
