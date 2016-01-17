﻿using UnityEngine;
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
		this.rigidbody2D.velocity = Vector2.right * speed;
	}

	void OnCollisionEnter2D(Collision2D col) {
		// Note: 'col' holds the collision information. If the
		// Ball collided with a racket, then:
		//   col.gameObject is the racket
		//   col.transform.position is the racket's position
		//   col.collider is the racket's collider
		
		// Hit the left Racket?
		if (col.gameObject.name == "paddle1") {
			// Calculate hit Factor
			float y = hitFactor(transform.position,
			                    col.transform.position,
			                    col.collider.bounds.size.y);
			
			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(1, y).normalized;
			
			// Set Velocity with dir * speed
			this.rigidbody2D.velocity = dir * speed;
		}
		
		// Hit the right Racket?
		if (col.gameObject.name == "paddle2") {
			// Calculate hit Factor
			float y = hitFactor(transform.position,
			                    col.transform.position,
			                    col.collider.bounds.size.y);
			
			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(-1, y).normalized;
			
			// Set Velocity with dir * speed
			this.rigidbody2D.velocity = dir * speed;
		}
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos,
	                float racketHeight) {
		// ascii art:
		// ||  1 <- at the top of the racket
		// ||
		// ||  0 <- at the middle of the racket
		// ||
		// || -1 <- at the bottom of the racket
		return (ballPos.y - racketPos.y) / racketHeight;
	}
}
