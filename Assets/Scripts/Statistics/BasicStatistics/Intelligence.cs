using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intelligence : Statistic
{
    public Intelligence(float baseValue, float currentValue)
    {
        Name = "Intelligence";
        Type = "General";
        BaseValue = baseValue;
        CurrentValue = CurrentValue;
    }
    public float IncreaseCurrentValue(float addedIntelligence)
    {
        return CurrentValue + addedIntelligence;
    }
}

