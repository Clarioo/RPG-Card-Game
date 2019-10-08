using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistic {

    public string Name { get; set; }
    public string Type { get; set; }
    public float BaseValue { get; set; }
    public float CurrentValue { get; set; }

    public float GetBaseValue()
    {
        if (BaseValue < 0)
            return BaseValue = 0;
        else
            return BaseValue;
    }
    public float GetCurrentValue()
    {
        if (CurrentValue < 0)
            return CurrentValue = 0;
        else
            return CurrentValue;
    }
    public float UpdateBaseValue(float lvl, float multiplier)
    {
        BaseValue = lvl * multiplier;
        return GetBaseValue();
    }

}
