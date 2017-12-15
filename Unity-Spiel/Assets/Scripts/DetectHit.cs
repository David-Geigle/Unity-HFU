using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectHit : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		GameObject.Find("Player").GetComponent<Leben>().TakeDamage(2);
		Debug.Log("Hit");
	}
    


}
