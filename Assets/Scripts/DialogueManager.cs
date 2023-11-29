using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    private int currentLine = 0;
    public Control control;
    bool paused;
    
    public void StartDialogue(string dialogue)
    {
        paused = control.paused;
        paused = true;
        DisplayNextLine(dialogue);
    }


    public void DisplayNextLine(string dialogue)
    {
        if (currentLine < dialogue.Length)
        {
            dialogueText.text = ""+dialogue[currentLine];
            currentLine++;
        }
        else
        {
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        paused = false;
    }
}
