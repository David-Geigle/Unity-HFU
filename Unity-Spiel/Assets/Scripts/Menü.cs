using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menü : MonoBehaviour {
    bool isMute;
    public Canvas MainCanvas;
    public Canvas CreditsCanvas;

    private void Awake()
    {
        CreditsCanvas.enabled = false;
    }
    public void CreditsOn()
    {
        CreditsCanvas.enabled = true;
        MainCanvas.enabled = false;
    }
    public void ReturnOn()
    {
        CreditsCanvas.enabled = false;
        MainCanvas.enabled = true;
    }
    public void NewGame()
        {
            SceneManager.LoadScene(1);
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
           SceneManager.LoadScene(PlayerPrefs.GetInt("currentscenesave"));
        }
    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }


}