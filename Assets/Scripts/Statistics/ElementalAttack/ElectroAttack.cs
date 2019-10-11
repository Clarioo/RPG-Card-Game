using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroAttack : Statistic
{
    public ElectroAttack(float baseValue)
    {
        Name = "ElectroAttack";
        Type = StatType.ElementalAttack;
        BaseValue = CurrentValue = baseValue;

    }

}
