using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : Statistic
{
    public AttackDamage(float baseValue)
    {
        Name = "AttackDamage";
        Type = StatType.Duel;
        BaseValue = CurrentValue = baseValue;
    }
}
