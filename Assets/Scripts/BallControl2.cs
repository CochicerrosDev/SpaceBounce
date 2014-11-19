using UnityEngine;
using System.Collections;

public class BallControl2 : MonoBehaviour {

	float horizontal = 0f;
	float vertical = 0f;
	float speed = 1f;
	GameObject[] ZonaNoo;

	// Update is called once per frame
	void Update () {	
		horizontal = Input.GetAxis ("Horizontal2");
		vertical = Input.GetAxis("Vertical2");

		ZonaNoo = GameObject.FindGameObjectsWithTag ("ZonaNo");
		foreach (GameObject go in ZonaNoo) {
			Physics2D.IgnoreCollision (go.collider2D, collider2D);
		}
	}

	void FixedUpdate(){	
		rigidbody2D.AddForce (new Vector2( horizontal,  vertical * speed) * 2);

		if (Input.GetKey (KeyCode.Space)) {
			rigidbody2D.AddForce (-rigidbody2D.velocity);
		}
	}
}

