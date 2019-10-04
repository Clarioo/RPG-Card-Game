using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intelligence : Statistic
{
    public Intelligence(float baseValue)
    {
        Name = "Intelligence";
        Type = "General";
        BaseValue = CurrentValue = baseValue;
    }
    public float IncreaseCurrentValue(float addedIntelligence)
    {
        return CurrentValue + addedIntelligence;
    }
}

