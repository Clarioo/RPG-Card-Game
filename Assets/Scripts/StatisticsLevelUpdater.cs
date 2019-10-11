using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Stats", menuName = "StatisticLevelUpdater" )]
public class StatisticsLevelUpdater : ScriptableObject
{
    public float StrenghtMultiplier { get; private set; }
    public float VitalityMultiplier { get; private set; }
    public float IntelligenceMultiplier { get; private set; }
    public float DexterityMultiplier { get; private set; }

    public float BaseAttackDamage { get; private set; }
    public float AttackDamageMultiplier { get; private set; }

    public float BaseArmour { get; private set; }
    public float ArmourMultiplier { get; private set; }

    public float BaseHealth { get; private set; }
    public float HealthMultiplier { get; private set; }

    public float BaseMana { get; private set; }
    public float ManaMultiplier { get; private set; }

    public float FireAttackMultiplier { get; private set; }
    public float WaterAttackMultiplier { get; private set; }
    public float ElectroAttackMultiplier { get; private set; }
    public float PoisonAttackMultiplier { get; private set; }


    
    public float GetBaseCalculatedAttackDamage(float level)
    {
        return BaseAttackDamage + AttackDamageMultiplier * level;
    }
    public float GetBaseCalculatedArmour(float level)
    {
        return BaseArmour + ArmourMultiplier * level;
    }
    public float GetBaseCalculatedHealth(float level)
    {
        return BaseHealth + HealthMultiplier * level;
    }
    public float GetBaseCalculatedMana(float level)
    {
        return BaseMana + ManaMultiplier * level;
    }

}
