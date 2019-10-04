using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitality : Statistic
{
    public Vitality(float baseValue)
    {
        Name = "Vitality";
        Type = "General";
        BaseValue = CurrentValue = baseValue;
    }

    public float IncreaseCurrentValue(float addedVitality)
    {
        return CurrentValue + addedVitality;
    }
}
