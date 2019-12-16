using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticUpdater : MonoBehaviour
{
    public Dictionary<string, Statistic> Stats;
    public Dictionary<Statistic, float> StatUpdater;



    public void SetStatUpdaters(StatisticsLevelUpdater statisticsLevelUpdater)
    {
        StatUpdater = new Dictionary<Statistic, float>
        {
            {Stats["Strenght"], statisticsLevelUpdater.BasicStatsMultipliers["Strenght"] },
            {Stats["Vitality"], statisticsLevelUpdater.BasicStatsMultipliers["Vitality"] },
            {Stats["Intelligence"], statisticsLevelUpdater.BasicStatsMultipliers["Intelligence"] },
            {Stats["Dexterity"], statisticsLevelUpdater.BasicStatsMultipliers["Dexterity"] }
        }
    }
    void UpdateBasicStatistics(Dictionary<string, Statistic> stats, StatisticsLevelUpdater statisticsLevelUpdater)
    {

    }

    void UpdateBasicStat()
    {

    }
    void UpdateDuelStat()
    {

    }

    

   
}
