using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectHit : MonoBehaviour {

    public GameObject Enemy;
    private Animator anim;


    /*    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Enemy")
            {
                GameObject.Find("Player").GetComponent<Leben>().TakeDamage(2);
                Debug.Log("Hit");
            }
        }*/

    private void Start()
    {
        anim = GetComponent<Animator>();
    }



    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Enemy" )
        {
            GameObject.Find("Player").GetComponent<Leben>().TakeDamage(2);
            Debug.Log("Hit");

        }

    }



}
