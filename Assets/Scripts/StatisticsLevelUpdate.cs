using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticsLevelUpdate : MonoBehaviour
{
    [SerializeField] float strenghtMultiplier, vitalityMultiplier, intelligenceMultiplier, dexterityMultiplier;

    public float StrenghtMultiplier
    {
        get { return strenghtMultiplier; }
    }
    public float VitalityMultiplier
    {
        get { return vitalityMultiplier; }
    }
    public float IntelligenceMultiplier
    {
        get { return intelligenceMultiplier; }
    }
    public float DexterityMultiplier
    {
        get { return dexterityMultiplier; }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
