using System.Collections;
using UnityEngine;

[RequireComponent(typeof(PlayerMotion))]
public class PlayerMovement : MonoBehaviour
{

	GameObject Player;
	PlayerMotion motion;
	public GameObject XMarker;

	Vector3 point;

	void Start()
	{
		motion = GetComponent<PlayerMotion>();
	}

	void Update()
	{

		if (Input.GetMouseButton(0) && !Pause.paused)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;


			if (Physics.Raycast(ray, out hit, 100))
			{
				motion.MoveToPoint(hit.point);
				point = hit.point;
			}
			foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Marker"))
			{
				Destroy(obj);
			}

			Instantiate(XMarker, point, Quaternion.identity);
		}

		


	}


}
