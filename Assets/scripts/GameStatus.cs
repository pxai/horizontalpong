using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStatus : MonoBehaviour {

	public static int pointsPlayer1 = 0;
	public static int pointsPlayer2 = 0;
	public Text pointsPlayer1Text;
	public Text pointsPlayer2Text;
	public static int maxHits = 5;
	public Text maxHitsText;
	public Slider sliderMaxHits;
	public Text outcomeText;

	// Use this for initialization
	void Start () {
		pointsPlayer1 = 0;
		pointsPlayer2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		pointsPlayer2Text.text = pointsPlayer2+"";
		pointsPlayer1Text.text = pointsPlayer1+"";
	}

	public void changeMaxHits () {
		maxHits = (int)sliderMaxHits.value;
		maxHitsText.text = maxHits + "";
		Debug.Log ("Modificado a " + maxHits);
	}

	public static void increaseLeft () {
		pointsPlayer2++;
	}


	public static void increaseRight () {
		pointsPlayer1++;
	}

	/*public static void updateOutcome () {
		string result = pointsPlayer1 + " - " + pointsPlayer2;
		result += GameStatus.outcome() + " wins";
		outcomeText.text = result;
	}*/

	public static string outcome () {
		if (pointsPlayer1 > pointsPlayer2) {
			return "Left";
		} else {
			return "Right";
		}
	}

	public static bool isFinished () {
		return pointsPlayer1 > maxHits || pointsPlayer2 > maxHits;
	}
}
