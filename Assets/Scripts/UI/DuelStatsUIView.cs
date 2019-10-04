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
        attackDmgTxt.text = duelStatistics.AttackDamage.GetCurrentValue().ToString();
        armourTxt.text = duelStatistics.Armour.GetCurrentValue().ToString();
        healthTxt.text = duelStatistics.Health.GetCurrentValue().ToString();
        manaTxt.text = duelStatistics.Mana.GetCurrentValue().ToString();
    }
    
}
