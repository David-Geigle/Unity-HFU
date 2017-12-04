using UnityEngine;

public class HealthHandeler : MonoBehaviour {


	public float Health = 100;
	public float currentHealth;
	
	void Start ()
	{
		currentHealth = Health;
	}
	
	
	void Update ()
	{


		if (currentHealth <= 0)
		{
			Destroy(gameObject);
		}
	}

	public void TakeDamage(float damage)
	{
		currentHealth = currentHealth - damage;

	}
}
