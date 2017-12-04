using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.AI;

public class TurnBackTime : MonoBehaviour {

	public static bool isRewinding = false;

	public float t = 2F; //Rückspulzeit

	public GameObject canvas;

	
	List<Vector3> positions;
	List<Quaternion> rotations;

	void Start ()
	{
		positions = new List<Vector3>();
		rotations = new List<Quaternion>();
	}


	void FixedUpdate()
	{
		if (isRewinding)
			Rewind();
		else
			Record();
	}

	void Record()
	{
		if (positions.Count > Mathf.Round(5F / Time.fixedDeltaTime))
		{
			positions.RemoveAt(positions.Count - 1); //alle Werte die älter als 5Sekunden sind werden gelöscht
			rotations.RemoveAt(rotations.Count - 1);
		}
			positions.Insert(0, transform.position); // neue Werte hinzufügen
			rotations.Insert(0, transform.rotation);
		

	}

	void Rewind()
	{
		if (positions.Count > 0)
		{
			transform.position = positions[0];
			positions.RemoveAt(0);
			transform.rotation = rotations[0];
			rotations.RemoveAt(0);
			gameObject.GetComponent<NavMeshAgent>().ResetPath();
		}
	}

	void Update ()
	{

		// Wenn "R" gedrückt wird und die Fäigkeit nicht auf Cooldown ist, wird die zeit 3s zurückgespult
		if (Input.GetKeyDown(KeyCode.R) && !RewindCooldown.isOnCooldown)
		{
			StartCoroutine("RewindTime");
			RewindCooldown.isOnCooldown = true;
			RewindCooldown.timeRemaining = RewindCooldown.Cooldown;
		}
	}

	IEnumerator RewindTime()
	{
		isRewinding = true;
		canvas.SetActive(true);
		yield return new WaitForSeconds(t);
		isRewinding = false;
		canvas.SetActive(false);
	}
}
