using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicStatsUIView : MonoBehaviour
{
    [SerializeField] Text levelTxt;
    [SerializeField] Text strenghtTxt, vitalityTxt, intelligenceTxt, dexterityTxt;


    public void UpdateLevelText(int level)
    {
        levelTxt.text = level.ToString();
    }
    public void UpdateBasicStatsUI(BasicStatistics basicStatistics)
    {
        strenghtTxt.text = basicStatistics.Strenght.GetCurrentValue().ToString();
        vitalityTxt.text = basicStatistics.Vitality.GetCurrentValue().ToString();
        intelligenceTxt.text = basicStatistics.Intelligence.GetCurrentValue().ToString();
        dexterityTxt.text = basicStatistics.Dexterity.GetCurrentValue().ToString();
    }
    
}
