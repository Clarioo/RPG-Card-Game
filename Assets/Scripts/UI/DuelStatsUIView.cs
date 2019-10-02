using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuelStatsUIView : MonoBehaviour
{
    [SerializeField] Text attackDmgTxt;
    [SerializeField] Text armourTxt;
    [SerializeField] Text healthTxt;
    [SerializeField] Text manaTxt;

    
    public void SetDuelStatsValuesOnUI(DuelStatistics duelStatistics)
    {
        attackDmgTxt.text = duelStatistics.attackDamage.GetCurrentValue().ToString();
        armourTxt.text = duelStatistics.armour.GetCurrentValue().ToString();
        healthTxt.text = duelStatistics.health.GetCurrentValue().ToString();
        manaTxt.text = duelStatistics.mana.GetCurrentValue().ToString();
    }
    
}
