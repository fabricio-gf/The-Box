using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour {

    public TextMesh displayText;
    public int points = 0;

    public Dialogue lightDialogue;
    public Dialogue wrongDialogue;
    public Dialogue rightDialogue;

    bool isRightTime;

    private void Start()
    {
        isRightTime = true;
        StartCoroutine(RandomLight());
    }

    public void PressButton()
    {
        if (!isRightTime)
        {
            DialogueManager.Instance.StartDialogue(wrongDialogue);
        }
        else
        {
            DialogueManager.Instance.StartDialogue(rightDialogue);
            points++;
            displayText.text = points.ToString();
            isRightTime = false;
        }
    }

    IEnumerator RandomLight()
    {
        yield return new WaitForSeconds(Random.Range(40f, 60f));
        if (!DialogueManager.Instance.isTalking)
        {
            DialogueManager.Instance.StartDialogue(lightDialogue);
            isRightTime = true;
        }
        StartCoroutine(RandomLight());
    }
}
