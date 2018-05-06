using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorBehaviour : MonoBehaviour {

    public Dialogue[] dialogues;
    int dialogueIndex = 0;

	public void ShowNextDialogue()
    {
        DialogueManager.Instance.StartDialogue(dialogues[dialogueIndex]);
        dialogueIndex++;
    }
}
