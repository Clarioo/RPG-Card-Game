using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armour : Statistic
{
    public Armour(float baseValue, float currentValue)
    {
        Name = "Armour";
        Type = "Duel";
        BaseValue = baseValue;
        CurrentValue = currentValue;
    }
}
