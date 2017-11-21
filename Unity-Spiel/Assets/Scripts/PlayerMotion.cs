using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotion : MonoBehaviour {

	NavMeshAgent agent;
	
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}


	public void MoveToPoint(Vector3 point)
	{
		agent.SetDestination(point);
		
	}

	void Update()
	{
		if (TurnBackTime.isRewinding)
			agent.isStopped = true;
		else
			agent.isStopped = false;


	}
}

