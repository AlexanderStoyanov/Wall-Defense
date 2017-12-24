using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_To_Main_Menu : MonoBehaviour {

	public void back()
    {
        SceneManager.LoadScene("main_menu");
    }
}
