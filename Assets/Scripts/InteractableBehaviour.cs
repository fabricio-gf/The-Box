using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractableBehaviour : MonoBehaviour {

    public Dialogue lookText;

    public bool canInteract;

    public Dialogue interactText;

    public void ShowText()
    {
        ShowLookText();
    }

	void ShowLookText()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(lookText);
    }

    void ShowInteractText()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(interactText);
    }
}
