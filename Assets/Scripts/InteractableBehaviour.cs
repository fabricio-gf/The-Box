using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBehaviour : MonoBehaviour {

    public Dialogue lookAtText;

	public void ShowLookAtText()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(lookAtText);
    }
}
