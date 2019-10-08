using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuelStatsUIView : UIUpdater
{
    [SerializeField] Text attackDmgTxt;
    [SerializeField] Text armourTxt;
    [SerializeField] Text healthTxt;
    [SerializeField] Text manaTxt;

    
    public void SetDuelStatsValuesOnUI(DuelStatistics duelStatistics)
    {
        UpdateStatisticTextValue(attackDmgTxt, duelStatistics.AttackDamage);
        UpdateStatisticTextValue(armourTxt, duelStatistics.Armour);
        UpdateStatisticTextValue(healthTxt, duelStatistics.Health);
        UpdateStatisticTextValue(manaTxt, duelStatistics.Mana);
    }



}
