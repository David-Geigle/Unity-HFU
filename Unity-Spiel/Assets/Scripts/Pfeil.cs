using UnityEngine;

public class Pfeil : MonoBehaviour {

	public GameObject Arrow;

	void Start ()
	{
		
	}
	
	
	void Update ()
	{

		// Wenn "Q" gedrückt wird und die Fäigkeit nicht auf Cooldown ist, wird ein Pfeil geschossen
		if (Input.GetKeyDown(KeyCode.Q) && !PfeilCooldown.isOnCooldown)
		{
			ShootArrow();
			PfeilCooldown.isOnCooldown = true;
			PfeilCooldown.timeRemaining = PfeilCooldown.Cooldown;
		}

	}

	void ShootArrow()
	{
		Vector3 Bow = new Vector3(transform.position.x, transform.position.y + 2F, transform.position.z);

		Ray ray = new Ray(Bow, new Vector3(0, gameObject.GetComponent<Transform>().rotation.y,0));

		Debug.DrawRay(ray.origin, ray.direction , Color.red);
		Gizmos.DrawRay(ray);

		Instantiate(Arrow, Bow, new Quaternion(0, gameObject.GetComponent<Transform>().rotation.y,0,0) );
		
	}
}
