using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public List<InventoryItems> items = new List<InventoryItems>();
    public Sprite icon;

    public bool HasItem(InventoryItems item)
    {
        return items.Contains(item);
    }

    public void AddItem(InventoryItems item)
    {
        items.Add(item);
        UpdateUI();
    }

    public void RemoveItem(InventoryItems item)
    {
        items.Add(item);
        UpdateUI();
    }

    private void UpdateUI()
    {
        //UI??
    }
}
