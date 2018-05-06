using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractableBehaviour : MonoBehaviour {

    public Dialogue lookText;

    public bool altLook = false;
    public Dialogue altLookText;

    public bool canInteract = false;
    public Dialogue interactText;

    public void ShowText()
    {
        if (canInteract)
        {
            DialogueManager.Instance.StartDialogue(interactText);
            PuzzleManager.Instance.NextPuzzle();
            canInteract = false;
            altLook = true;
        }
        else if (altLook)
        {
            DialogueManager.Instance.StartDialogue(altLookText);
        }
        else
        {
            DialogueManager.Instance.StartDialogue(lookText);
        }

    }
}
