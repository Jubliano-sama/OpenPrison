using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public UIInventory inventoryUI;
    private void Start()
    {
        // testing
        GiveItem("Gray Pants");
        GiveItem("Gray Pants");
        GiveItem("Gray Pants");
        GiveItem("Gray Pants");
        GiveItem("Gray Pants");
        GiveItem("Gray Shirt");
    }
    public void GiveItem(int id)
    {
        Item itemToAdd = ItemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }
    public void GiveItem(string itemName)
    {
        Item itemToAdd = ItemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }
    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }
    public void RemoveItem(int id)
    {
        Item item = CheckForItem(id);
        if(item != null)
        {
            characterItems.Remove(item);
            inventoryUI.RemoveItem(item);
            Debug.Log("Item removed: " + item.title);
        }
        else
        {
            Debug.LogWarning("Item not found, not removing id: " + id);
        }
    }

}
