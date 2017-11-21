using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	float visiblePos = -6.5f;
	private GameObject gameOverText;
	private GameObject scoreText;
	int score = 0;

	// Use this for initialization
	void Start () {
		this.gameOverText = GameObject.Find ("GameOverText");
		this.scoreText = GameObject.Find ("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.z < visiblePos) {
			this.gameOverText.GetComponent<Text>().text = "Game Over";

			if (Input.GetMouseButton (0)) {
				SceneManager.LoadScene ("GameScene");
			}
		}
	}

	void OnCollisionEnter(Collision other){
		Debug.Log ("a");
		if(other.gameObject.tag == "SmallStarTag"){
			score += 1;
			Debug.Log ("a");
		}else if(other.gameObject.tag == "LargeStarTag"){
			score += 5;
		}else if(other.gameObject.tag == "SmallCloudTag"){
			score += 10;
			Debug.Log("a");
		}else if(other.gameObject.tag == "LargeCloudTag"){
			score += 15;
		}
		this.scoreText.GetComponent<Text> ().text = "Score " + score.ToString();
	}
}
