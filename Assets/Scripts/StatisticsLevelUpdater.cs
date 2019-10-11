using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Stats", menuName = "StatisticLevelUpdater" )]
public class StatisticsLevelUpdater : ScriptableObject
{
    [SerializeField] float strenghtMultiplier, vitalityMultiplier, intelligenceMultiplier, dexterityMultiplier;
    [SerializeField] float baseAttackDamage, attackDamageMultiplier;
    [SerializeField] float baseArmour, armourMultiplier;
    [SerializeField] float baseHealth, healthMultiplier;
    [SerializeField] float baseMana, manaMultiplier;
    [SerializeField] float fireAttackMultiplier, waterAttackMultiplier, electroAttackMultiplier, poisonAttackMultiplier;
    [SerializeField] float fireDefenseMultiplier, waterDefenseMultiplier, electroDefenseMultiplier, poisonDefenseMultiplier;

    public float StrenghtMultiplier { get { return strenghtMultiplier; } private set { } }
    public float VitalityMultiplier { get { return vitalityMultiplier; } private set { } }
    public float IntelligenceMultiplier { get { return intelligenceMultiplier; } private set { } }
    public float DexterityMultiplier { get { return dexterityMultiplier; } private set { } }

    public float BaseAttackDamage { get { return baseAttackDamage; } private set { } }
    public float AttackDamageMultiplier { get { return attackDamageMultiplier; } private set { } }

    public float BaseArmour { get { return baseArmour; } private set { } }
    public float ArmourMultiplier { get { return armourMultiplier; } private set { } }

    public float BaseHealth { get { return baseHealth; } private set { } }
    public float HealthMultiplier { get { return healthMultiplier; } private set { } }

    public float BaseMana { get { return baseMana; } private set { } }
    public float ManaMultiplier { get { return manaMultiplier; } private set { } }

    public float FireAttackMultiplier { get { return fireAttackMultiplier; } private set { } }
    public float WaterAttackMultiplier { get { return waterAttackMultiplier; } private set { } }
    public float ElectroAttackMultiplier { get { return electroAttackMultiplier; } private set { } }
    public float PoisonAttackMultiplier { get { return poisonAttackMultiplier; } private set { } }

    public float FireDefenseMultiplier { get { return fireDefenseMultiplier; } private set { } }
    public float WaterDefenseMultiplier { get { return waterDefenseMultiplier; } private set { } }
    public float ElectroDefenseMultiplier { get { return electroDefenseMultiplier; } private set { } }
    public float PoisonDefenseMultiplier { get { return poisonDefenseMultiplier; } private set { } }



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
