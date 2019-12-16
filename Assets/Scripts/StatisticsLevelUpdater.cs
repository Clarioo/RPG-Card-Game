using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticsLevelUpdater : MonoBehaviour
{
    [SerializeField] float strenghtMultiplier, vitalityMultiplier, intelligenceMultiplier, dexterityMultiplier;
    [SerializeField] float baseAttackDamage, attackDamageMultiplier;
    [SerializeField] float baseArmour, armourMultiplier;
    [SerializeField] float baseHealth, healthMultiplier;
    [SerializeField] float baseMana, manaMultiplier;

    public Dictionary<string, float> BasicStatsMultipliers;

    private void Start()
    {
        BasicStatsMultipliers = new Dictionary<string, float>
        {
            {"Strenght", StrenghtMultiplier },
            {"Vitality", VitalityMultiplier },
            {"Intelligence", IntelligenceMultiplier },
            {"Dexterity", DexterityMultiplier }
        };
    }
    public float StrenghtMultiplier
    {
        get { return strenghtMultiplier; }
    }
    public float VitalityMultiplier
    {
        get { return vitalityMultiplier; }
    }
    public float IntelligenceMultiplier
    {
        get { return intelligenceMultiplier; }
    }
    public float DexterityMultiplier
    {
        get { return dexterityMultiplier; }
    }
    
    public float GetBaseCalculatedAttackDamage(float level)
    {
        return baseAttackDamage + attackDamageMultiplier * level;
    }
    public float GetBaseCalculatedArmour(float level)
    {
        return baseArmour + armourMultiplier * level;
    }
    public float GetBaseCalculatedHealth(float level)
    {
        return baseHealth + healthMultiplier * level;
    }
    public float GetBaseCalculatedMana(float level)
    {
        return baseMana + manaMultiplier * level;
    }

}
