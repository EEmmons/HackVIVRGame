using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyMotion : MonoBehaviour {

	public Rigidbody rb;
	public float thrust;

	// Use this for initialization
	void Start () {
		//rb.AddForce(0, 2000, 5000);
		rb = GetComponent<Rigidbody>();
		//thrust = rb.AddForce(0, 2000, 5000);
		rb.AddForce(0, 0, thrust, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//rb.AddForce(0, 0, thrust, ForceMode.Impulse);
	}
}
