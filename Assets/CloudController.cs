using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

	float magSpeed = 10.0f;
	float minimum = 1.0f;
	float magnification = 0.07f;


	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3 (this.minimum + Mathf.Sin (Time.time * magSpeed) * magnification, transform.localScale.y, this.minimum + Mathf.Sin (Time.time * magSpeed) * magnification);
	}
}
