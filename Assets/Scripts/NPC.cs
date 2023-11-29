using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public InventoryItems itemWant;
    public InventoryItems itemHave;

    [TextArea(3, 10)]
    public string dialogueNoItem;
    [TextArea(3, 10)]
    public string dialogueHasItem;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(other.GetComponent<InventorySystem>().HasItem(itemWant))
                {
                    other.GetComponent<DialogueManager>().StartDialogue(dialogueHasItem);
                }
                else
                {
                    other.GetComponent<DialogueManager>().StartDialogue(dialogueNoItem);
                }
            }
        }
    }
}
