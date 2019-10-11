using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonAttack : Statistic
{
    public PoisonAttack(float baseValue)
    {
        Name = "PoisonAttack";
        Type = StatType.ElementalAttack;
        BaseValue = CurrentValue = baseValue;

    }

}
