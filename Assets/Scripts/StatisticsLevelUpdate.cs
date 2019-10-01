using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticsLevelUpdate : MonoBehaviour
{
    [SerializeField] List<string> basicBattleStatsMultiplierKeys;
    [SerializeField] List<int> basicBattleStatsMultipierValues;
    public Dictionary<string, int> basicBattleStatsLevelMultiplier;
    
    // Start is called before the first frame update
    void Start()
    {
        FillBasicBattleStatsLevelMultiplier();   
    }

    private void FillBasicBattleStatsLevelMultiplier()
    {
        basicBattleStatsLevelMultiplier = new Dictionary<string, int>()
        {
            { basicBattleStatsMultiplierKeys[0], basicBattleStatsMultipierValues[0] },
            { basicBattleStatsMultiplierKeys[1], basicBattleStatsMultipierValues[1] },
            { basicBattleStatsMultiplierKeys[2], basicBattleStatsMultipierValues[2] },
            { basicBattleStatsMultiplierKeys[3], basicBattleStatsMultipierValues[3] }

        };
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
