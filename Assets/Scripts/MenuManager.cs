using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public static MenuManager Instance;

	AudioSource music;
    public GameObject quitPanel;
    bool isQuitPanelOpen = false;

    public Animator BlackScreen;

    public NarratorBehaviour narrator;

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

        if (SceneManager.GetActiveScene().name == "Game" || SceneManager.GetActiveScene().name == "End")
        {
            StartCoroutine(FadeIn());
            narrator = GameObject.FindGameObjectWithTag("Narrator").GetComponent<NarratorBehaviour>();
        }
        music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
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

    public void CallQuitGame()
    {
        StartCoroutine(QuitGame());
    }

    public IEnumerator QuitGame()
    {
        BlackScreen.SetBool("isOn", true);
        yield return new WaitForSeconds(0.5f);

        Application.Quit();
    }

    public void Mute(bool mute){
		music.mute = mute;
	}

	public void ChangeScene(string sceneName){
        StartCoroutine(FadeOut(sceneName));		
	}

    IEnumerator FadeIn()
    {
        BlackScreen.SetBool("isOn", false);
        yield return new WaitForSeconds(0.5f);
        narrator.ShowNextDialogue();
    }

    IEnumerator FadeOut(string sceneName)
    {
        BlackScreen.SetBool("isOn", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName);
    }

}
