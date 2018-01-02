using UnityEngine;
using System.Collections;

public class EmptyCSharpFile : MonoBehaviour {
	public Transform spawnPoint;

	void OnTriggerEnter(Collider other) {
		other.gameObject.transform.position = spawnPoint.position;
	}
}
