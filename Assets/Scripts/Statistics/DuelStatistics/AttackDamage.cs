using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : Statistic
{
    public AttackDamage(float baseValue, float currentValue)
    {
        Name = "AttackDamage";
        Type = "Duel";
        BaseValue = baseValue;
        CurrentValue = currentValue;
    }
}
