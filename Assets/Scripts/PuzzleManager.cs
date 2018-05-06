using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour {

    public static PuzzleManager Instance;

    int PuzzleIndex = 0;
    public InteractableBehaviour[] PuzzleList;

    public Animator ItemListAnimator;

	// Use this for initialization
	void Start () {
        //Check if instance already exists
        if (Instance == null)

            //if not, set instance to this
            Instance = this;

        //If instance already exists and it's not this:
        else if (Instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        PuzzleList[0].canInteract = true;
    }
	
	public void NextPuzzle()
    {
        switch (PuzzleIndex)
        {
            case 0:
                ItemListAnimator.SetBool("isOpen", true);
                //add item?
                break;
            default:
                break;
        }
        PuzzleIndex++;
        if(PuzzleIndex < PuzzleList.Length)
            PuzzleList[PuzzleIndex].canInteract = true;
    }
}
