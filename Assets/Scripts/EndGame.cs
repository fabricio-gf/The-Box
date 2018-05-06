using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

    public bool isEnd = false;

    public int count = 0;

	public void End()
    {
        if (isEnd && count == 1)
        {
            MenuManager.Instance.ChangeScene("End");
        }
        else if (isEnd && count == 0)
        {
            count++;
            Destroy(GetComponent<InteractableBehaviour>());
        }
    }
}
