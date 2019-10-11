using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAttack : Statistic
{
    public WaterAttack(float baseValue)
    {
        Name = "WaterAttack";
        Type = StatType.ElementalAttack;
        BaseValue = CurrentValue = baseValue;

    }

    public float IncreaseCurrentValue(float addedStrenght)
    {
        return CurrentValue + addedStrenght;
    }
}
