using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strenght : Statistic
{
    public Strenght(float baseValue)
    {
        Name = "Strenght";
        Type = "General";
        BaseValue = CurrentValue = baseValue;
        
    }
    
    public float IncreaseCurrentValue(float addedStrenght)
    {
        return CurrentValue + addedStrenght;
    }
}
