using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStatistics : MonoBehaviour
{
    Strenght strenght;
    Vitality vitality;
    Intelligence intelligence;
    Dexterity dexterity;

    public Strenght Strenght { get { return strenght; } set { strenght = value; } }
    public Vitality Vitality { get { return vitality; } set { vitality = value; } }
    public Intelligence Intelligence { get { return intelligence; } set { intelligence = value; } }
    public Dexterity Dexterity { get { return dexterity; } set { dexterity = value; } }

    StatisticsLevelUpdate statisticsLevelUpdate;


    public BasicStatistics(StatisticsLevelUpdate statisticsLevelUpdate)
    {
        this.statisticsLevelUpdate = statisticsLevelUpdate;
        CreateBasicStats();
    }

    private void CreateBasicStats()
    {
        strenght = new Strenght(statisticsLevelUpdate.StrenghtMultiplier);
        vitality = new Vitality(statisticsLevelUpdate.VitalityMultiplier);
        intelligence = new Intelligence(statisticsLevelUpdate.IntelligenceMultiplier);
        dexterity = new Dexterity(statisticsLevelUpdate.DexterityMultiplier);
    }
    public void UpdateBaseStrenght(float level, float multiplier)
    {
        strenght.UpdateBaseValue(level, multiplier);
    }
    public void UpdateBaseVitality(float level, float multiplier)
    {
        vitality.UpdateBaseValue(level, multiplier);
    }
    public void UpdateBaseIntelligence(float level, float multiplier)
    {
        intelligence.UpdateBaseValue(level, multiplier);
    }
    public void UpdateBaseDexterity(float level, float multiplier)
    {
        dexterity.UpdateBaseValue(level, multiplier);
    }
    public void UpdateStatsBasedOnLevel(float level, StatisticsLevelUpdate statisticsLevelUpdate)
    {
        Strenght.UpdateBaseValue(level, statisticsLevelUpdate.StrenghtMultiplier);
        Vitality.UpdateBaseValue(level, statisticsLevelUpdate.VitalityMultiplier);
        Intelligence.UpdateBaseValue(level, statisticsLevelUpdate.IntelligenceMultiplier);
        Dexterity.UpdateBaseValue(level, statisticsLevelUpdate.DexterityMultiplier);
    }
    public void UpdateCurrentStatsBasedOnBaseStats()
    {
        strenght.CurrentValue = strenght.GetBaseValue();
        vitality.CurrentValue = vitality.GetBaseValue();
        intelligence.CurrentValue = intelligence.GetBaseValue();
        dexterity.CurrentValue = dexterity.GetBaseValue();
    }

}
