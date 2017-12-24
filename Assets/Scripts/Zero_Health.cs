using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zero_Health : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ScoreManager.healthCount == 0)
        {
            SceneManager.LoadScene("main_menu");
        }
	}
}
