using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public ItemType itemType;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();
    public Item(int id, string title, string description, ItemType itemType,
        Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Textures/Items/" + title);
        this.stats = stats;
        this.itemType = itemType;
    }
    public Item(int id, string title, string description, ItemType itemType,
        Dictionary<string, int> stats, Sprite icon)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = icon;
        this.stats = stats;
        this.itemType = itemType;
    }
    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = item.icon;
        this.stats = item.stats;
        
    }
}

public enum ItemType {clothing}
