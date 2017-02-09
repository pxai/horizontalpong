using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public int speed = 20;
	public static bool dead = false;

	// Use this for initialization
	void Start () {
		spawn ();
	}
	
	// Update is called once per frame
	void Update () {
		if (dead) {
			spawn ();
		}
	}

	void spawn () {
		dead = false;
		this.transform.position = new Vector3 (5f,5f,0f);
		this.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Vector2 direction;
				
		// (ball.y - paddle.y) / paddle.height
		float y = (transform.position.y - collision.transform.position.y)/collision.collider.bounds.size.y;

		Debug.Log (transform.position.y + "-" + collision.transform.position.y + "/" + collision.collider.bounds.size.y + " = " + y);

		// paddle1
		if (collision.gameObject.name == "paddle1") {
			direction = new Vector2(1, y).normalized;
			this.GetComponent<Rigidbody2D>().velocity = direction * speed;
		}
		
		// paddle2
		if (collision.gameObject.name == "paddle2") {
			direction = new Vector2(-1, y).normalized;
			this.GetComponent<Rigidbody2D>().velocity = direction * speed;
		}
	}


}
