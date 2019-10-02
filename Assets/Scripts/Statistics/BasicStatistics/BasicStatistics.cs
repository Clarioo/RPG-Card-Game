using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStatistics : MonoBehaviour
{
    public Strenght strenght;
    public Vitality vitality;
    public Intelligence intelligence;
    public Dexterity dexterity;
    
    public BasicStatistics(float strenghtValue, float vitalityValue, float intelligenceValue, float dexterityValue)
    {
        strenght = new Strenght(strenghtValue, strenghtValue);
        vitality = new Vitality(vitalityValue, vitalityValue);
        intelligence = new Intelligence(intelligenceValue, intelligenceValue);
        dexterity = new Dexterity(dexterityValue, dexterityValue);
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
    public void UpdateCurrentStatsBasedOnBaseStats()
    {
        strenght.CurrentValue = strenght.GetBaseValue();
        vitality.CurrentValue = vitality.GetBaseValue();
        intelligence.CurrentValue = intelligence.GetBaseValue();
        dexterity.CurrentValue = dexterity.GetBaseValue();
    }

}
