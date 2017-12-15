using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leben : MonoBehaviour {

    public Texture2D lebensrahmen;
    public Texture2D lebengruen;
    public int leben;
	public int aktuellesleben;
    private int groesseLebensanzeige;

    // Use this for initialization
    void Start () {
        groesseLebensanzeige = 5;
		aktuellesleben = leben;
    }
	
	// Update is called once per frame
	void Update () {

        if (aktuellesleben <= 0)
        {
            Pause.GameOver();
        }
		
	}

	public void TakeDamage(int damage)
	{
		aktuellesleben = aktuellesleben - damage;
		if (aktuellesleben > leben)//kein overheal
			aktuellesleben = leben;
	}

	private void OnGUI()
    {
        GUI.DrawTexture(new Rect(10, 10, 792 / groesseLebensanzeige, 335 / groesseLebensanzeige), lebensrahmen);
        for (int i = 0; i < aktuellesleben; i++)
        {
            GUI.DrawTexture(new Rect(18.7f + (73 / groesseLebensanzeige) * i, 10, 73 / groesseLebensanzeige, 335 / groesseLebensanzeige), lebengruen);
        }


    }
}


