using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelStatistics : MonoBehaviour
{
    public AttackDamage attackDamage;
    public Armour armour;
    public Health health;
    public Mana mana;

    DuelStatsUIView duelStatsUIView;

    public DuelStatistics(float attackDamageValue, float armourValue, float healthValue, float manaValue)
    {
        attackDamage = new AttackDamage(attackDamageValue, attackDamageValue);
        armour = new Armour(armourValue, armourValue);
        health = new Health(healthValue, healthValue);
        mana = new Mana(manaValue, manaValue);
    }

    public void UpdateDuelStatistics(float level, StatisticsLevelUpdate statisticsLevelUpdate)
    {
        attackDamage.CurrentValue = attackDamage.BaseValue = statisticsLevelUpdate.GetBaseCalculatedAttackDamage(level);
        armour.CurrentValue = armour.BaseValue = statisticsLevelUpdate.GetBaseCalculatedArmour(level);
        health.CurrentValue = health.BaseValue = statisticsLevelUpdate.GetBaseCalculatedHealth(level);
        mana.CurrentValue = mana.BaseValue = statisticsLevelUpdate.GetBaseCalculatedMana(level);
    }

    private void Awake()
    {
        duelStatsUIView = GetComponent<DuelStatsUIView>();
    }



}
