using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStatistics : StatisticUpdater
{
    Strenght strenght;
    Vitality vitality;
    Intelligence intelligence;
    Dexterity dexterity;

    public Strenght Strenght { get { return strenght; } set { strenght = value; } }
    public Vitality Vitality { get { return vitality; } set { vitality = value; } }
    public Intelligence Intelligence { get { return intelligence; } set { intelligence = value; } }
    public Dexterity Dexterity { get { return dexterity; } set { dexterity = value; } }


    StatisticsLevelUpdater statisticsLevelUpdate;

    BasicStatsUIView basicStatsUIView;


    public BasicStatistics(StatisticsLevelUpdater statisticsLevelUpdate, BasicStatsUIView basicStatsUIView)
    {
        this.statisticsLevelUpdate = statisticsLevelUpdate;
        this.basicStatsUIView = basicStatsUIView;

        CreateBasicStats(); 
    }

    private void CreateBasicStats()
    {
        strenght = new Strenght(statisticsLevelUpdate.StrenghtMultiplier);
        vitality = new Vitality(statisticsLevelUpdate.VitalityMultiplier);
        intelligence = new Intelligence(statisticsLevelUpdate.IntelligenceMultiplier);
        dexterity = new Dexterity(statisticsLevelUpdate.DexterityMultiplier);

        Stats = new Dictionary<string, Statistic>
        {
            {"Strenght", Strenght },
            {"Vitality", Vitality },
            {"Intelligence", Intelligence },
            {"Dexterity", Dexterity }
        };
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
        vitality.CurrentValue = vitality.GetBaseValue();
        intelligence.CurrentValue = intelligence.GetBaseValue();
        dexterity.CurrentValue = dexterity.GetBaseValue();
    }

    


}
