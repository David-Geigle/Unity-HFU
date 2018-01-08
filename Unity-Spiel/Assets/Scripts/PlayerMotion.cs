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

		if (agent.hasPath == true && Blitz.isCasting == false) // laufen
		{
			anim.SetBool("isWalking", true);
			anim.SetBool("isIdle", false);
		}

		else if (Blitz.isCasting == true)//Cast
		{
			anim.SetBool("isIdle", false);
			anim.SetBool("isCasting", true);
			anim.SetBool("isWalking", false);
			agent.ResetPath();
		}

		else if (Input.GetMouseButton(1)) //autoattack
		{
			anim.SetBool("isIdle", false);
			anim.SetBool("isCasting", false);
			anim.SetBool("isWalking", false);
			anim.SetBool("isAttacking", true);
			agent.ResetPath();
		}
		
		else //idle
		{
			anim.SetBool("isWalking", false);
			anim.SetBool("isIdle", true);
			anim.SetBool("isCasting", false);
			anim.SetBool("isAttacking", false);
		}
	}
}

