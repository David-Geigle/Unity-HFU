using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    GameObject PauseMenu;
	public static bool paused;
    bool isMute;
    public GameSave MyGameSave;


	void Start () {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
        MyGameSave = GameObject.Find("GameSave").GetComponent<GameSave>();


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
		SceneManager.LoadScene(0);
    }

    public void Save()
    {
        //PlayerPrefs.SetInt("currentscenesave", Application.loadedLevel);
        MyGameSave.savePos();

    }

    public void Load()
    {
        //SceneManager.LoadScene(PlayerPrefs.GetInt("currentscenesave"));
        MyGameSave.loadPos();
    }

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }
    public void Quit()
    {
		Debug.Log("ENDE!");
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
}
