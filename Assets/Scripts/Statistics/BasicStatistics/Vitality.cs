using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitality : Statistic
{
    public Vitality(float baseValue, float currentValue)
    {
        Name = "Vitality";
        Type = "General";
        BaseValue = baseValue;
        CurrentValue = currentValue;
    }

    public float IncreaseCurrentValue(float addedVitality)
    {
        return CurrentValue + addedVitality;
    }
}
