using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    public static ItemManager Instance;

    public GameObject[] Items;
    int ItemIndex = 0;

    private void Start()
    {
        //Check if instance already exists
        if (Instance == null)

            //if not, set instance to this
            Instance = this;

        //If instance already exists and it's not this:
        else if (Instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
    }

    public void ShowNextItem()
    {
        if (ItemIndex < Items.Length)
        {
            Items[ItemIndex].SetActive(true);
            ItemIndex++;
        }
    }
}
