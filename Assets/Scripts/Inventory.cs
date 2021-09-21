using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    private void Start()
    {
        GiveItem("Diamond Sword");
        GiveItem(1);
        GiveItem(2);
        RemoveItem(1);
       
    }
    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }
    public void GiveItem(string Itemname)
    {
        Item itemToAdd = itemDatabase.GetItem(Itemname);
        characterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }
    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }
    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);
        if (!itemToRemove)
        {
            characterItems.Remove(itemToRemove);
            Debug.Log("Removed item: " + itemToRemove.title);
        }
    }

}
