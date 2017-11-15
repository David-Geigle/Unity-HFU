using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    GameObject PauseMenu;
    bool paused;
    bool isMute;


	void Start () {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");

		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        
        }
	}
    public void Resume()
    {
        paused = false;

    }

    public void MainMenu()
    {
        Application.LoadLevel(0);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("currentscenesave", Application.loadedLevel);

    }

    public void Load()
    {
        Application.LoadLevel(PlayerPrefs.GetInt("currentscenesave"));
    }

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        Application.LoadLevel(1);
    }
}
