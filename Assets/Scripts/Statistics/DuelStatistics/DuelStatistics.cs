using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelStatistics : MonoBehaviour
{
    AttackDamage attackDamage;
    Armour armour;
    Health health;
    Mana mana;

    public AttackDamage AttackDamage { get { return attackDamage; } set { attackDamage = value; } }
    public Armour Armour { get { return armour; } set { armour = value; } }
    public Health Health { get { return health; } set { health = value; } }
    public Mana Mana { get { return mana; } set { mana = value; } }

    StatisticsLevelUpdate statisticsLevelUpdate;
    float level;

    DuelStatsUIView duelStatsUIView;

    public DuelStatistics(StatisticsLevelUpdate statisticsLevelUpdate, float level)
    {
        this.statisticsLevelUpdate = statisticsLevelUpdate;
        this.level = level;
        CreateDuelStatistics();
    }

    private void CreateDuelStatistics()
    {
        AttackDamage = new AttackDamage(statisticsLevelUpdate.GetBaseCalculatedAttackDamage(level));
        Armour = new Armour(statisticsLevelUpdate.GetBaseCalculatedArmour(level));
        Health = new Health(statisticsLevelUpdate.GetBaseCalculatedHealth(level));
        Mana = new Mana(statisticsLevelUpdate.GetBaseCalculatedMana(level));
    }

    public void UpdateDuelStatistics(StatisticsLevelUpdate _statisticsLevelUpdate, float _level)
    {
        level = _level;
        statisticsLevelUpdate = _statisticsLevelUpdate;

        AttackDamage.CurrentValue = AttackDamage.BaseValue = statisticsLevelUpdate.GetBaseCalculatedAttackDamage(level);
        Armour.CurrentValue = Armour.BaseValue = statisticsLevelUpdate.GetBaseCalculatedArmour(level);
        Health.CurrentValue = Health.BaseValue = statisticsLevelUpdate.GetBaseCalculatedHealth(level);
        Mana.CurrentValue = Mana.BaseValue = statisticsLevelUpdate.GetBaseCalculatedMana(level);
    }

    private void Awake()
    {
        duelStatsUIView = GetComponent<DuelStatsUIView>();
    }



}
