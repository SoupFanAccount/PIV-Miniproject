using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trading : MonoBehaviour
{
    public InventorySystem playerInventory;
    public InventorySystem npcInventory;

    public void TradeItem(InventoryItems playerItem, InventoryItems npcItem, NPC itemWant)
    {
        if(playerItem == itemWant)
        {
            playerInventory.RemoveItem(playerItem);
            npcInventory.AddItem(playerItem);

            npcInventory.RemoveItem(npcItem);
            playerInventory.AddItem(npcItem); playerInventory.RemoveItem(playerItem);
        }
    }
}
