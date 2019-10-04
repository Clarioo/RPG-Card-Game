using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dexterity : Statistic
{
    public Dexterity(float baseValue)
    {
        Name = "Dexterity";
        Type = "General";
        BaseValue = CurrentValue = baseValue;
    }
    public float IncreaseCurrentValue(float addedDexterity)
    {
        return CurrentValue + addedDexterity;
    }
}

