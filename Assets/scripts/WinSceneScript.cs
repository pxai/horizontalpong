using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text result = GameObject.Find ("SubTitle").GetComponent<Text> ();
		result.text = GameStatus.pointsPlayer1 + " - " + GameStatus.pointsPlayer2;

		if (GameStatus.pointsPlayer1 > GameStatus.pointsPlayer2) {
			result.text += " Player1 (Left) wins!";
		} else {
			result.text += " Player2 (right) wins!";
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
