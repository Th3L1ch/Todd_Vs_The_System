using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rs : MonoBehaviour {

    public string levelToBeLoaded;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            SceneManager.LoadScene(levelToBeLoaded);
        }
    }
    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Application.LoadLevel(levelToBeLoaded);
            SceneManager.LoadScene(levelToBeLoaded);
        }
    }
    */
}
