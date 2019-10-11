using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAttack : Statistic
{
    public FireAttack(float baseValue)
    {
        Name = "FireAttack";
        Type = StatType.ElementalAttack;
        BaseValue = CurrentValue = baseValue;

    }
}
