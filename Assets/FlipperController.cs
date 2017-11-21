using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour {

	private HingeJoint myHingeJoint;
	float defaultAngle = 20;
	float flickAngle = -20;

	// Use this for initialization
	void Start () {
		myHingeJoint = GetComponent<HingeJoint> ();

		SetAngle (this.defaultAngle);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow) && tag == "LeftFlipperTag") {
			SetAngle (flickAngle);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow) && tag == "RightFlipperTag") {
			SetAngle (flickAngle);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow) && tag == "LeftFlipperTag") {
			SetAngle (defaultAngle);
		}
		if (Input.GetKeyUp (KeyCode.RightArrow) && tag == "RightFlipperTag") {
			SetAngle (defaultAngle);
		}
	}
		
	void SetAngle(float angle){
		JointSpring jointSpr = myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		myHingeJoint.spring = jointSpr;
	}
}
