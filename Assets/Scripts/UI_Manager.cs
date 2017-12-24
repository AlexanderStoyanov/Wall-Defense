using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UI_Manager : MonoBehaviour {

    GameObject[] pauseObjects;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("PauseObject");
        hidePause();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                
            }
        }

    }

    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPause();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePause();
        }
    }

    public void hidePause()
    {
        foreach(GameObject p in pauseObjects) {
            p.SetActive(false);
        }
    }

    public void showPause()
    {
        foreach(GameObject p in pauseObjects) {
            p.SetActive(true);
        }
    }

}
