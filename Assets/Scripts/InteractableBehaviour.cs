using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBehaviour : MonoBehaviour {

    public Dialogue lookText;

    public bool canInteract;

    public Dialogue interactText;

	public void ShowLookText()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(lookText);
    }

    public void ShowInteractText()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(interactText);
    }
}
