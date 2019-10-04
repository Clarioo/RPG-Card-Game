using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armour : Statistic
{
    public Armour(float baseValue)
    {
        Name = "Armour";
        Type = "Duel";
        BaseValue = CurrentValue = baseValue;
    }
}
