using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUIView : MonoBehaviour
{
    [SerializeField] Text levelTxt;
    [SerializeField] Text strenghtTxt, vitalityTxt, intelligenceTxt, dexterityTxt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateLevelText(int level)
    {
        levelTxt.text = level.ToString();
    }
    public void UpdateBasicStatsUI(float strenght, float vitality, float intelligence, float dexterity)
    {
        strenghtTxt.text = strenght.ToString();
        vitalityTxt.text = vitality.ToString();
        intelligenceTxt.text = intelligence.ToString();
        dexterityTxt.text = dexterity.ToString();
    }
}
