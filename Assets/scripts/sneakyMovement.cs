using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneakyMovement : MonoBehaviour {

    public Rigidbody2D rb;
    public Transform tf;
    public float moveSpeed;
    public float turnSpeed;
    public float angle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * (Time.deltaTime * moveSpeed));
        }

        if (Input.GetKey(KeyCode.S))
        {

            rb.AddForce(-transform.up * (Time.deltaTime * moveSpeed));
        }

        if (Input.GetKey(KeyCode.A))
        {
            angle += (turnSpeed * Time.deltaTime);
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        if (Input.GetKey(KeyCode.D))
        {
            angle -= (turnSpeed * Time.deltaTime);
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
