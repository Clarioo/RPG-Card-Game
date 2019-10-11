using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDefense : Statistic
{
    public WaterDefense(float baseValue)
    {
        Name = "WaterDefense";
        Type = StatType.ElementalDefense;
        BaseValue = CurrentValue = baseValue;

    }
}
