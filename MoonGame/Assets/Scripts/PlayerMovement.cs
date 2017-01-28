using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	Rigidbody2D rb2d;

	public float speed = 1;
	public float movex;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		rb2d.velocity = new Vector2(movex * speed, rb2d.velocity.y);
	}
}
