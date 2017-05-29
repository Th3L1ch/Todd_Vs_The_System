using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    public string loadedLvl;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LevelLoad(Collider other)
    {
        if (other.tag == "Player")
        {
            //SceneManager.LoadScene(loadedLvl);
            Application.LoadLevel(loadedLvl);
        }
    }
}
