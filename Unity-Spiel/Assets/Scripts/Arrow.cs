using UnityEngine;

public class Arrow : MonoBehaviour {

	public float force = 1000F;
	Vector3 direction;

	 GameObject emitter;

	void Start ()
	{
		emitter = GameObject.FindGameObjectWithTag("Player");
		float y = emitter.GetComponent<Transform>().rotation.y;
		direction = new Vector3(y,0, 0).normalized;
		Debug.Log(y);
		Debug.Log(direction);
		gameObject.GetComponent<Rigidbody>().AddForce(direction*force,ForceMode.VelocityChange);
		Destroy(gameObject, 3F);
	}
	
	
	void Update ()
	{
		
	}
}
