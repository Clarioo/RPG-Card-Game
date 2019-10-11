using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementalStatsUIView : UIUpdater
{
    [SerializeField] Text fireAttackTxt;
    [SerializeField] Text waterAttackTxt;
    [SerializeField] Text electroAttackTxt;
    [SerializeField] Text poisonAttackTxt;

    [SerializeField] Text fireDefenseTxt;
    [SerializeField] Text waterDefenseTxt;
    [SerializeField] Text electroDefenseTxt;
    [SerializeField] Text poisonDefenseTxt;

    public void SetElementalAttackValuesOnUI(ElementalAttackStats elementalAttackStats)
    {
        UpdateStatisticTextValue(fireAttackTxt, elementalAttackStats.FireAttack);
        UpdateStatisticTextValue(waterAttackTxt, elementalAttackStats.WaterAttack);
        UpdateStatisticTextValue(electroAttackTxt, elementalAttackStats.ElectroAttack);
        UpdateStatisticTextValue(poisonAttackTxt, elementalAttackStats.PoisonAttack);
    }
    public void SetElementalDefenseValuesOnUI(ElementalDefenseStats elementalDefenseStats)
    {
        UpdateStatisticTextValue(fireDefenseTxt, elementalDefenseStats.FireDefense);
        UpdateStatisticTextValue(waterDefenseTxt, elementalDefenseStats.WaterDefense);
        UpdateStatisticTextValue(electroDefenseTxt, elementalDefenseStats.ElectroDefense);
        UpdateStatisticTextValue(poisonDefenseTxt, elementalDefenseStats.PoisonDefense);
    }
      
}
