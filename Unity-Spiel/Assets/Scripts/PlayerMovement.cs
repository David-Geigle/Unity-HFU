using UnityEngine;

[RequireComponent(typeof(PlayerMotion))]
public class PlayerMovement : MonoBehaviour {

    GameObject Player;
	PlayerMotion motion;

	void Start()
	{
		motion = GetComponent<PlayerMotion>();
	}

	void Update () {

        if (Input.GetMouseButton(0) && !Pause.paused)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;


			if(Physics.Raycast(ray, out hit, 100))
			{
				motion.MoveToPoint(hit.point);

			}

		}
        



    }
}
