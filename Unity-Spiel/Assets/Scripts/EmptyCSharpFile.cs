using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EmptyCSharpFile : MonoBehaviour {
	public GameObject spawnPoint;
	public NavMeshAgent agent;

	void Start()
	{
		agent = GameObject.FindGameObjectWithTag("Player").GetComponent<NavMeshAgent>();
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player")
		{
			agent.Warp(spawnPoint.transform.position);
		}
	}
}
