using UnityEngine;

public class Destroy : MonoBehaviour {

	
	void Start ()
	{
		//Nach 1.5 sekunden wird das objekt mit diesem Script zerstört
		Destroy(gameObject, 1.5F);
	}
	
	
	void Update ()
	{
		
	}
}
