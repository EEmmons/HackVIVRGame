using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskMotion : MonoBehaviour {

	// initial throw
	public Rigidbody rb;
	public float thrust;

	// attraction to far side of field
	public GameObject attractedToOrange;
	public GameObject attractedToBlue;
	public float strengthOfAttraction = 5.0f;

	// change wall color
	public Color whiteDisc;
	public Color orangeWall;
	public Color tealWall;

	// Use this for initialization
	void Start () {
		//rb.AddForce(0, 2000, 5000);
		rb = GetComponent<Rigidbody>();
		//thrust = rb.AddForce(0, 2000, 5000);
		rb.AddForce(0, 0, thrust, ForceMode.Impulse);

	}       


	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag ("NorthWall")) 
		{
			// attractedTo.transform.GetComponent<Renderer>().material.color = orangeWall;
			attractedToOrange.transform.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
		}

		if (other.gameObject.CompareTag ("SouthWall")) 
		{            
			// attractedTo.transform.GetComponent<Renderer>().material.color = tealWall;
			attractedToBlue.transform.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
		}
	}
	

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 directionOrange = attractedToOrange.transform.position - transform.position;
		Vector3 directionBlue = attractedToOrange.transform.position - transform.position;

		rb.AddForce(strengthOfAttraction * directionOrange);
		rb.AddForce(strengthOfAttraction * directionBlue);
	}
}

