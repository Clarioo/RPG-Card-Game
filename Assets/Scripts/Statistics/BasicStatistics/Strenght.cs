using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strenght : Statistic
{
    public Strenght(float baseValue, float currentValue)
    {
        Name = "Strenght";
        Type = "General";
        BaseValue = baseValue;
        CurrentValue = currentValue;
    }
    
    public float IncreaseCurrentValue(float addedStrenght)
    {
        return CurrentValue + addedStrenght;
    }
}
