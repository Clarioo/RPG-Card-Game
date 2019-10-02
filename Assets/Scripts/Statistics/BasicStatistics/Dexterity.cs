using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dexterity : Statistic
{
    public Dexterity(float baseValue, float currentValue)
    {
        Name = "Dexterity";
        Type = "General";
        BaseValue = baseValue;
        CurrentValue = CurrentValue;
    }
    public float IncreaseCurrentValue(float addedDexterity)
    {
        return CurrentValue + addedDexterity;
    }
}

