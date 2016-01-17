using UnityEngine;
using System.Collections;

public class LeftCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider) {
		Debug.Log  ("Left player lose!");
		GameStatus.increaseRight();
		
		if (GameStatus.isFinished ()) {
			Application.LoadLevel ("Win");
		} else {
			Ball.dead = true;
		}
	}
}
