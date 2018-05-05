using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public AudioSource music;

	public void Mute(bool mute){
		music.mute = mute;
	}

	public void ChangeScene(string sceneName){
		SceneManager.LoadScene (sceneName);
	}
}
