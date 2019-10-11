using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonDefense : Statistic
{
    public PoisonDefense(float baseValue)
    {
        Name = "PoisonDefense";
        Type = StatType.ElementalDefense;
        BaseValue = CurrentValue = baseValue;

    }
}
