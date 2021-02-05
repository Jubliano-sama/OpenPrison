using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    private TextMeshProUGUI tooltip;
    void Start()
    {
        tooltip = GetComponentInChildren<TextMeshProUGUI>();
        gameObject.SetActive(false);
    }
    public void GenerateTooltip(Item item)
    {
        string statText = "";
        if(item.stats.Count > 0)
        {
            foreach(KeyValuePair<string, int> stat in item.stats)
            {
                statText += stat.Key.ToString() + ": " + stat.Value.ToString() + "\n";
            }
        }
        tooltip.text = statText;
        gameObject.SetActive(true); 
    }

}
