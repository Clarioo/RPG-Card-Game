using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : Statistic
{
    float maxHealt;
    public float MaxHealth
    {
        get { return maxHealt; }
        set { maxHealt = value; }
    }
    public Health(float baseValue, float currentValue)
    {
        Name = "Health";
        Type = "Duel";
        BaseValue = baseValue;
        CurrentValue = currentValue;
        MaxHealth = currentValue;
    }
}
