using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public string loadedLvl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadLevel(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(loadedLvl);
        }
    }
}
