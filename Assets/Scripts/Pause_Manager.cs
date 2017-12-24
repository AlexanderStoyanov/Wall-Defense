using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Manager : MonoBehaviour {


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        foreach (Transform child in this.transform)
        {
            if (Time.timeScale == 1)
            {
                child.gameObject.SetActive(false);
            }
            else if (Time.timeScale == 0)
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
