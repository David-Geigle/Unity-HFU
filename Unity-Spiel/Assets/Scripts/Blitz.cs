using UnityEngine;

public class Blitz : MonoBehaviour {


	
	void Start ()
	{
		
	}
	
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Q) && !ZauberCooldown.isOnCooldown)
		{
			ZauberCooldown.isOnCooldown = true;
			ZauberCooldown.timeRemaining = ZauberCooldown.Cooldown;
			BlitzCast();
		}
	}

	void BlitzCast()
	{
		


	}
}
