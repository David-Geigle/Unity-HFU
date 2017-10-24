using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    GameObject Player;
    Rigidbody rb;
    public float force;

    void Start () {

        Player = this.gameObject;
        rb = Player.GetComponent<Rigidbody>();
	}
	

	void FixedUpdate () {

        if (Input.GetKey("w"))
        {
            rb.AddForce( 0 , 0 , force * Time.deltaTime, ForceMode.Acceleration);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce( 0 , 0 , -force * Time.deltaTime, ForceMode.Acceleration);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * Time.deltaTime , 0 , 0 , ForceMode.Acceleration);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(force * Time.deltaTime , 0 , 0  , ForceMode.Acceleration);
        }



    }
}
