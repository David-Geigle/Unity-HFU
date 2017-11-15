using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menü : MonoBehaviour {
    bool isMute;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
    }
        public void NewGame()
        {
            Application.LoadLevel(1);
        }
        public void Quit()
        {
            Application.Quit();
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


}