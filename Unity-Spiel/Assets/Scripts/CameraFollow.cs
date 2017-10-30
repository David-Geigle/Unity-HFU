using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
    // Variablen
	public GameObject player; 
    public float yOffset, zOffset;
   
    


	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
	}
	

	void LateUpdate () {

		Camera.main.transform.position = player.transform.position + new Vector3(0f,yOffset,-zOffset);

	}


}
