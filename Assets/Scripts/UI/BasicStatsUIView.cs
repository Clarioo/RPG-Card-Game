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
        strenghtTxt.text = basicStatistics.strenght.GetCurrentValue().ToString();
        vitalityTxt.text = basicStatistics.vitality.GetCurrentValue().ToString();
        intelligenceTxt.text = basicStatistics.intelligence.GetCurrentValue().ToString();
        dexterityTxt.text = basicStatistics.dexterity.GetCurrentValue().ToString();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
