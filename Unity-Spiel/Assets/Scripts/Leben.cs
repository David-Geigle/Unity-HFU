using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leben : MonoBehaviour {

    public Texture2D lebensrahmen;
    public Texture2D lebengruen;
    private int leben;
    private int groesseLebensanzeige;

    // Use this for initialization
    void Start () {
        leben = 10;
        groesseLebensanzeige = 5;

    }
	
	// Update is called once per frame
	void Update () {

        if (leben == 0)
        {
            Pause.GameOver();
        }
		
	}


    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(10, 10, 792 / groesseLebensanzeige, 335 / groesseLebensanzeige), lebensrahmen);
        for (int i = 0; i < leben; i++)
        {
            GUI.DrawTexture(new Rect(18.7f + (73 / groesseLebensanzeige) * i, 10, 73 / groesseLebensanzeige, 335 / groesseLebensanzeige), lebengruen);
        }


    }
}


