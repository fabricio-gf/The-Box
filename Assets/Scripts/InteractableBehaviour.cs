using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBehaviour : MonoBehaviour {

    public Dialogue lookText;

	public void ShowLookAtText()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(lookText);
    }
}
