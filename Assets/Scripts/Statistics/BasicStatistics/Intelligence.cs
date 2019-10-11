using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intelligence : Statistic
{
    public Intelligence(float baseValue)
    {
        Name = "Intelligence";
        Type = StatType.General;
        BaseValue = CurrentValue = baseValue;
    }
    
}

