using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicStatsUIView : UIUpdater
{
    [SerializeField] Text levelTxt;
    [SerializeField] Text strenghtTxt, vitalityTxt, intelligenceTxt, dexterityTxt;

    BasicStatistics basicStatistics;

    public void UpdateLevelText(int level)
    {
        levelTxt.text = level.ToString();
    }
    public void UpdateBasicStatsUI(BasicStatistics basicStatistics)
    {
        UpdateStatisticTextValue(strenghtTxt, basicStatistics.Strenght);
        UpdateStatisticTextValue(vitalityTxt, basicStatistics.Vitality);
        UpdateStatisticTextValue(intelligenceTxt, basicStatistics.Intelligence);
        UpdateStatisticTextValue(dexterityTxt, basicStatistics.Dexterity);
    }
    
}
