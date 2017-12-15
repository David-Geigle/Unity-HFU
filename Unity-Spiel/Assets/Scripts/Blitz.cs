using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Blitz : MonoBehaviour
{

	BoxCollider box;

	ParticleSystem Sys;

	public float t = 2;
	public float Damage;

    public Texture2D BlitzNormal;

	AudioSource AudioSource;

	public static bool isCasting = false;

    void Start()
	{
		box = gameObject.GetComponent<BoxCollider>();
		box.enabled = false;

		Sys = gameObject.GetComponent<ParticleSystem>();
		Sys.Stop();

		AudioSource = gameObject.GetComponent<AudioSource>();
	}

  /*  private void OnGUI()
    {
        GUI.DrawTexture(new Rect(200, 400, 100, 100), BlitzNormal);
    }*/


    void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q) && !ZauberCooldown.isOnCooldown)
		{
			ZauberCooldown.isOnCooldown = true;
			ZauberCooldown.timeRemaining = ZauberCooldown.Cooldown;
			box.enabled = true;

			Sys.Play();

			AudioSource.Play();

			isCasting = true;

			StartCoroutine("BlitzCast");
		}
	}

	IEnumerator BlitzCast()
	{
		yield return new WaitForSeconds(t);
		box.enabled = false;
		Sys.Stop();
		isCasting = false;
		
	}



	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Hit");
		if (other.tag == "Enemy" ) // wenn das getroffene Objekt den Tag Enemy hat
		{
			Debug.Log(other.name +" hat " + Damage + " Schaden erhalten.");
			GameObject.Find(other.name).GetComponent<HealthHandeler>().TakeDamage(Damage);
		}
	}

	
}
