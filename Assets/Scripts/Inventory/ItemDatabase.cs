using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase: MonoBehaviour
{
    public static List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDataBase();
    }

    public static void BuildDataBase()
    {
        items = new List<Item> {
            new Item(0, "Gray Shirt", "A plain gray shirt.",
            new Dictionary<string, int>
            {
                {"Protection", 1},
                {"Contraband", 0},
                {"ItemType", (int)ItemType.clothing}
            }),
            new Item(1, "Gray Pants", "Plain gray pants.",
            new Dictionary<string, int>
            {
                {"Protection", 1},
                {"Contraband", 0},
                {"ItemType", (int)ItemType.clothing}
            })
        };
    }

    public static Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public static Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }
}
