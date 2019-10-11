using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dexterity : Statistic
{
    public Dexterity(float baseValue)
    {
        Name = "Dexterity";
        Type = StatType.General;
        BaseValue = CurrentValue = baseValue;
    }
    
}

