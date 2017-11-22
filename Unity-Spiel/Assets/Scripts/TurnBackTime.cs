using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class TurnBackTime : MonoBehaviour {

	public static bool isRewinding = false;

	public float t = 3F; //Rückspulzeit

	public Canvas canvas;

	
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
		}
	}

	void Update ()
	{

		// Wenn "R" gedrückt wird wird die zeit 3s zurückgespult
		if (Input.GetKeyDown(KeyCode.R))
			StartCoroutine( "RewindTime");
		
	}

	IEnumerator RewindTime()
	{
		isRewinding = true;
		yield return new WaitForSeconds(t);
		isRewinding = false;
	}
}
