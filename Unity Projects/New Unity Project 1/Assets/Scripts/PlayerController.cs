﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float jumpHeight;
	public float moveSpeed;
	public static int currentNum = 1;
	public static int lives = 5;
	public GameObject number;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
		}

		if (transform.position.x == 4.0f) {
			Instantiate (number, new Vector3(15.0f, 0,0), transform.rotation);
		}

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);

		anim.SetFloat ("Speed", Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x));
	}
}
