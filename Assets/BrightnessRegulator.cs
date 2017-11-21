using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour {

	Material myMaterial;

	float minEmission = 0.3f;
	float magEmission = 2.0f;
	int degree = 0;
	int speed = 10;

	Color defaultColor = Color.white;

	// Use this for initialization
	void Start () {
		if (tag == "SmallStarTag") {
			this.defaultColor = Color.white;
		} else if (tag == "LargeStarTag") {
			this.defaultColor = Color.yellow;
		} else if (tag == "SmallCloudTag" || tag == "LargeCloudTag") {
			this.defaultColor = Color.blue;
		}

		myMaterial = GetComponent<Renderer> ().material;
		myMaterial.SetColor ("_EmissionColor", defaultColor * minEmission);
	}
	
	// Update is called once per frame
	void Update () {
		if (degree >= 0) {
			Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin (degree * Mathf.Deg2Rad) * magEmission);

			myMaterial.SetColor ("_EmissionColor", emissionColor);

			this.degree -= speed;
		}
	}

	void OnCollionEnter(Collision other){
		this.degree = 180;
	}
}
