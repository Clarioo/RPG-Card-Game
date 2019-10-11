using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelStatistics
{
    AttackDamage attackDamage;
    Armour armour;
    Health health;
    Mana mana;

    public AttackDamage AttackDamage { get { return attackDamage; } set { attackDamage = value; } }
    public Armour Armour { get { return armour; } set { armour = value; } }
    public Health Health { get { return health; } set { health = value; } }
    public Mana Mana { get { return mana; } set { mana = value; } }

    StatisticsLevelUpdater statisticsLevelUpdater;
    DuelStatsUIView duelStatsUIView;

    float level;

    public DuelStatistics(StatisticsLevelUpdater statisticsLevelUpdate, float level, DuelStatsUIView duelStatsUIView)
    {
        this.statisticsLevelUpdater = statisticsLevelUpdate;
        this.level = level;
        this.duelStatsUIView = duelStatsUIView;
        CreateDuelStatistics();
    }

    private void CreateDuelStatistics()
    {
        AttackDamage = new AttackDamage(statisticsLevelUpdater.GetBaseCalculatedAttackDamage(level));
        Armour = new Armour(statisticsLevelUpdater.GetBaseCalculatedArmour(level));
        Health = new Health(statisticsLevelUpdater.GetBaseCalculatedHealth(level));
        Mana = new Mana(statisticsLevelUpdater.GetBaseCalculatedMana(level));
        duelStatsUIView.SetDuelStatsValuesOnUI(this);
    }

    public void UpdateDuelStatistics(float level)
    {
        AttackDamage.CurrentValue = AttackDamage.BaseValue = statisticsLevelUpdater.GetBaseCalculatedAttackDamage(level);
        Armour.CurrentValue = Armour.BaseValue = statisticsLevelUpdater.GetBaseCalculatedArmour(level);
        Health.CurrentValue = Health.BaseValue = statisticsLevelUpdater.GetBaseCalculatedHealth(level);
        Mana.CurrentValue = Mana.BaseValue = statisticsLevelUpdater.GetBaseCalculatedMana(level);
        duelStatsUIView.SetDuelStatsValuesOnUI(this);
    }

    



}
