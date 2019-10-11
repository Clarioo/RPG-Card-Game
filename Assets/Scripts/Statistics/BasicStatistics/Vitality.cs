using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitality : Statistic
{
    public Vitality(float baseValue)
    {
        Name = "Vitality";
        Type = StatType.General;
        BaseValue = CurrentValue = baseValue;
    }

}
