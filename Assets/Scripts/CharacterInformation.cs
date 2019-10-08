using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInformation : MonoBehaviour, CharacterUpdater
{
    [SerializeField] string _name;
    [SerializeField] string _class;
    [SerializeField] string _race;
    [SerializeField] int level;

    public string _Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string _Class
    {
        get { return _class; }
        set { _class = value; }
    }
    public int _Level
    {
        get { return level; }
        set { if (level + value <= 1)
                level = 1;
            else
                level = value;
            }
    }

    public void IncreaseLevel()
    {
        _Level++;
    }
    public void DecreaseLevel()
    {
        _Level--;
    }
    
}
