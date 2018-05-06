using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementBehaviour : MonoBehaviour {

    Animator animator;

    public float openDuration;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.SetBool("isOpen", true);
        print("go");
        StartCoroutine(WaitForClose(openDuration));
    }
	
    IEnumerator WaitForClose(float dur)
    {
        print("cr");
        yield return new WaitForSeconds(dur);
        print("cr end");
        animator.SetBool("isOpen", false);
    }
}
