using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotion : MonoBehaviour {

	NavMeshAgent agent;
	Animator anim;
	
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		anim = GetComponent<Animator>();
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

		if (agent.hasPath == true)
		{
			anim.SetBool("isWalking", true);
			anim.SetBool("isIdle", false);
		}

		else
		{
			anim.SetBool("isWalking", false);
			anim.SetBool("isIdle", true);
		}
	}
}

