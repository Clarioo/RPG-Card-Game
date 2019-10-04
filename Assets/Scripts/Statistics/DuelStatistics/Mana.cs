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

    public Mana(float baseValue)
    {
        Name = "Mana";
        Type = "Duel";
        BaseValue = CurrentValue = MaxMana = baseValue;
    }
}
