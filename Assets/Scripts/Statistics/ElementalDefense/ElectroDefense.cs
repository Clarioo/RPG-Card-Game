using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroDefense : Statistic
{
    public ElectroDefense(float baseValue)
    {
        Name = "ElectroDefense";
        Type = StatType.ElementalDefense;
        BaseValue = CurrentValue = baseValue;

    }
}
