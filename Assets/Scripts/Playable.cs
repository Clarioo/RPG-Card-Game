using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playable : MonoBehaviour
{
    CharacterInformation characterInformation;
    BattleStatistics battleStatistics;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public virtual CharacterInformation GetCharacterInformation()
    {
        return characterInformation;
    }
    public virtual BattleStatistics GetBattleStatistics()
    {
        return battleStatistics;
    }
    public virtual void UpdateStatisticsBasedOnLevel()
    {
    }
    public virtual void LevelUp()
    {
        characterInformation._Level++;
        UpdateStatisticsBasedOnLevel();
    }
}
