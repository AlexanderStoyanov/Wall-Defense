using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution_Manager : MonoBehaviour {

    List<string> res_options = new List<string>() {"1280x720", "1920x1080" };

    public Dropdown dropdown;
    public Boolean fs = false;
    public Toggle toggle;
    public int width = Screen.width;
    public int height = Screen.height;

	// Use this for initialization
	void Start() {

        AddResolutions();
        toggle.isOn = Screen.fullScreen;

	}
	
	// Update is called once per frame
	void Update () {
        //Screen.SetResolution(width, height, fs);
    }

    public void ToggleFullscreen()
    {
        if (toggle.isOn)
        {
            fs = true;
            Screen.fullScreen = true;
        }

        if (!toggle.isOn)
        {
            fs = false;
            Screen.fullScreen = false;
        }
    }

    public void AddResolutions()
    {
        dropdown.AddOptions(res_options);
    }

    public void ChangeResolution(int index)
    {
        if (res_options[index].Equals("1280x720"))
        {
            width = 1280;
            height = 720;
            Screen.SetResolution(width, height, fs);
        }
        if (res_options[index].Equals("1920x1080"))
        {
            width = 1920;
            height = 1080;
            Screen.SetResolution(width, height, fs);
        }
    }

}
