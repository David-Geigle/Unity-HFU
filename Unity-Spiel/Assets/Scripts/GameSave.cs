using UnityEngine;


public class GameSave : MonoBehaviour
{

    public Transform ObjectToSave;

    // Use this for initialization



    void Awake()
    {
        if (ObjectToSave == null)
        {
            ObjectToSave = gameObject.transform;
        }
    }


    public void loadPos()
    {
        Debug.Log("Laden");
        Debug.Log(ObjectToSave.position.x);
        Debug.Log(ObjectToSave.position.y);
        Debug.Log(ObjectToSave.position.z);
        if (PlayerPrefs.HasKey(name + "xPos"))
        {
            

            ObjectToSave.position = new Vector3(

                PlayerPrefs.GetFloat(name + "xPos"),
                PlayerPrefs.GetFloat(name + "yPos"),
                PlayerPrefs.GetFloat(name + "zPos")


                );


            Pause.paused = false;
        }

    }

    public void savePos()
    {
        Debug.Log("Speichern");

        PlayerPrefs.SetFloat(name + "xPos", ObjectToSave.position.x);
        PlayerPrefs.SetFloat(name + "yPos", ObjectToSave.position.y);
        PlayerPrefs.SetFloat(name + "zPos", ObjectToSave.position.z);
        PlayerPrefs.Save();

        Debug.Log(ObjectToSave.position.x);
        Debug.Log(ObjectToSave.position.y);
        Debug.Log(ObjectToSave.position.z);

    }


    // Update is called once per frame
    void Update()
    {

    }
}
