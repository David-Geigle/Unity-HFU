using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menü : MonoBehaviour {
    bool isMute;
    public Canvas MainCanvas;
    public GameObject CreditsCanvas;

    private void Awake()
    {
        CreditsCanvas.SetActive(false);
    }
    public void CreditsOn()
    {
        CreditsCanvas.SetActive(true);
        MainCanvas.enabled = false;
    }
    public void ReturnOn()
    {
        CreditsCanvas.SetActive(false);
        MainCanvas.enabled = true;
    }
    public void NewGame()
        {
            SceneManager.LoadScene(2);
        }
    public void NewGameStart()
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