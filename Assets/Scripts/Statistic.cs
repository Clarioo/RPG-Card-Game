using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistic {

    public string Name { get; set; }
    public string Type { get; set; }
    public float BaseValue { get; set; }
    public float CurrentValue { get; set; }

    public Statistic(string _name, string _type, float _baseValue, float _currentValue)
    {
        this.Name = _name;
        this.Type = _type;
        this.BaseValue = _baseValue;
        this.CurrentValue = _currentValue;
    }
}
