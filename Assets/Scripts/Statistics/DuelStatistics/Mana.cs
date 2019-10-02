using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : Statistic
{
    float maxMana;
    public float MaxMana
    {
        get { return maxMana; }
        set { maxMana = value; }
    }

    public Mana(float baseValue, float currentValue)
    {
        Name = "Mana";
        Type = "Duel";
        BaseValue = baseValue;
        CurrentValue = currentValue;
        MaxMana = CurrentValue;
    }
}
