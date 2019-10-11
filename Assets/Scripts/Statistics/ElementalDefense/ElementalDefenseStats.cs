using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalDefenseStats
{
    public FireDefense FireDefense { get; private set; }
    public WaterDefense WaterDefense { get; private set; }
    public ElectroDefense ElectroDefense { get; private set; }
    public PoisonDefense PoisonDefense { get; private set; }

    ElementalStatsUIView elementalStatsUIView;

    public ElementalDefenseStats()
    {

    }
}
