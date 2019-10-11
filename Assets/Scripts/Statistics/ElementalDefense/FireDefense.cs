using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDefense : Statistic
{
    public FireDefense(float baseValue)
    {
        Name = "FireDefense";
        Type = StatType.ElementalDefense;
        BaseValue = CurrentValue = baseValue;

    }

}
