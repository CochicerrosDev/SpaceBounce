using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	float horizontal = 0f;
	float vertical = 0f;
	float speed = 2f;

	// Update is called once per frame
	void Update () {
		horizontal = Input.GetAxis ("Horizontal");
		vertical = Input.GetAxis("Vertical");
	}

	void FixedUpdate(){
		rigidbody2D.velocity = new Vector2 (vertical*Mathf.Pow(speed, 2), rigidbody2D.velocity.y);
		Debug.Log (rigidbody2D.velocity);
		Debug.Log (Mathf.Pow (speed, 2));
		rigidbody2D.velocity = new Vector2 (horizontal * speed, rigidbody2D.velocity.x);		
		Debug.Log (rigidbody2D.velocity);
	}
}
