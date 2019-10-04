using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : Statistic
{
    public AttackDamage(float baseValue)
    {
        Name = "AttackDamage";
        Type = "Duel";
        BaseValue = CurrentValue = baseValue;
    }
}
