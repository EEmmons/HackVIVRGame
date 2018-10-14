using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallChangeColor : MonoBehaviour {

	public Color redcolor;
	public Color bluecolor;


	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag ("NorthWall")) 
		{           
			Debug.Log ("It's ALIVE and red");
			transform.GetComponent<Renderer>().material.color= redcolor;
		}

		if (other.gameObject.CompareTag ("SouthWall")) 
		{            
			Debug.Log ("It's ALIVE and blue");
			transform.GetComponent<Renderer>().material.color= bluecolor;
		}
	}
}