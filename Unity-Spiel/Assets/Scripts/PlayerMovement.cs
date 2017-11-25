using System.Collections;
using UnityEngine;

[RequireComponent(typeof(PlayerMotion))]
public class PlayerMovement : MonoBehaviour
{

	GameObject Player;
	PlayerMotion motion;
	public GameObject XMarker;
    public Texture2D lebensrahmen;
    public Texture2D lebengruen;
    private int leben;
    private int groesseLebensanzeige;
    Vector3 point;

  

    void Start()
	{
		motion = GetComponent<PlayerMotion>();
        leben = 10;
        groesseLebensanzeige = 5;
    
    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(10,10,792/ groesseLebensanzeige, 335/ groesseLebensanzeige),lebensrahmen);
        for (int i = 0; i < leben; i++)
        {
            GUI.DrawTexture(new Rect(18.7f+(73/ groesseLebensanzeige)* i, 10, 73/groesseLebensanzeige, 335/ groesseLebensanzeige), lebengruen);
        }


    }

    void Update()
	{
		//Raycasten
		if (Input.GetMouseButton(0) && !Pause.paused)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;


			if (Physics.Raycast(ray, out hit, 100))
			{
				motion.MoveToPoint(hit.point);
				point = hit.point;
			}
			//alle existierenden Marker zerstören
			foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Marker"))
			{
				Destroy(obj);
			}
			//Marker erzeugen
			Instantiate(XMarker, point, Quaternion.identity);
		}

		


	}


}
