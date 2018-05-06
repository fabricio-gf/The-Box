using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public AudioSource music;
    public GameObject quitPanel;
    bool isQuitPanelOpen = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("pause");

            if (!isQuitPanelOpen)
                OpenPanel(quitPanel);
            else
                ClosePanel(quitPanel);
        }
    }

    public void OpenPanel(GameObject panel)
    {
        isQuitPanelOpen = true;
        panel.GetComponent<Animator>().SetBool("isOpen", true);
    }

    public void ClosePanel(GameObject panel)
    {
        isQuitPanelOpen = false;
        panel.GetComponent<Animator>().SetBool("isOpen", false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Mute(bool mute){
		music.mute = mute;
	}

	public void ChangeScene(string sceneName){
		SceneManager.LoadScene (sceneName);
	}
}
