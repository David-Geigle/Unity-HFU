using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    #region Singleton
    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player;
    public GameObject Handy;


    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Handy")
        {
            Handy.SetActive(false);
            Invoke("Gewonnen", 1);
            
        }

    }

    public void Gewonnen()
    {
        Pause.Gewonnen();
    }

}