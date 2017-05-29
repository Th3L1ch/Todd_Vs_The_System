using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour {

    public string loadedLvl;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void PlayGame()
    {
        SceneManager.LoadScene(loadedLvl);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
