using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strenght : Statistic
{
    public Strenght(float baseValue)
    {
        Name = "Strenght";
        Type = StatType.General;
        BaseValue = CurrentValue = baseValue;
        
    }
}
