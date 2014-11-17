﻿using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	float horizontal = 0f;
	float vertical = 0f;
	float speed = 1f;

	// Update is called once per frame
	void Update () {
		horizontal = Input.GetAxis ("Horizontal");
		vertical = Input.GetAxis("Vertical");
	}

	void FixedUpdate(){	
		rigidbody2D.AddForce (new Vector2( horizontal,  vertical * speed) * 5);
	}
}

