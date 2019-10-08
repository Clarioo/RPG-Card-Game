using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UIUpdater : MonoBehaviour
{
    public void UpdateStatisticTextValue(Text statisticText, Statistic statistic)
    {
        statisticText.text = statistic.GetCurrentValue().ToString();
    }
}
