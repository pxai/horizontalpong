using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public int speed = 1;
	public string axeName = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePosition = new Vector3 (this.transform.position.x ,this.transform.position.y,0);

		float v = Input.GetAxisRaw(axeName);
		this.rigidbody2D.velocity = new Vector2(0, v) * speed;

		paddlePosition.y = Mathf.Clamp (paddlePosition.y,0.5f, 10f);
		this.transform.position = paddlePosition;
	}
}
