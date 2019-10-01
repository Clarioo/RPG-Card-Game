using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStatistics : MonoBehaviour {

    public Dictionary<string, Statistic> generalStats;
    public Dictionary<string, Statistic> duelStats;
    public Dictionary<string, Statistic> elementalAttack;
    public Dictionary<string, Statistic> elementalDefense;
	// Use this for initialization

	public BattleStatistics(float strenght, float vitality, float intelligence, float dexterity)
    {
        InitializeGeneralStatistics(strenght, vitality, intelligence, dexterity);
    }
    void InitializeGeneralStatistics(float strenght, float vitality, float intelligence, float dexterity)
    {
        generalStats = new Dictionary<string, Statistic>()
        {
            { "Strenght", new Statistic("Strenght", "general", strenght, strenght) },
            { "Vitality", new Statistic("Vitality", "general", vitality, vitality) },
            { "Intelligence", new Statistic("Intelligence", "general", intelligence, intelligence) },
            { "Dexterity",  new Statistic("Dexterity", "general", dexterity, dexterity) }

        };
    }


	


	
}
