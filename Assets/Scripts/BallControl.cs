using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	float horizontal = 0f;
	float vertical = 0f;
	float speed = 1f;
	GameObject[] ZonaNoo;

	void start(){
		
	}


	// Update is called once per frame
	void Update () {
		horizontal = Input.GetAxis ("Horizontal");
		vertical = Input.GetAxis("Vertical");

		ZonaNoo = GameObject.FindGameObjectsWithTag ("ZonaNo");
		foreach (GameObject go in ZonaNoo) {
			Physics2D.IgnoreCollision (go.collider2D, collider2D);
		}

	}

	void FixedUpdate(){	
		rigidbody2D.AddForce (new Vector2( horizontal,  vertical * speed) * 5);

	}

	/*void OnCollisionEnter2D(Collision2D coll){
				if (coll.gameObject.tag == "ZonaNo") {
			Physics2D.IgnoreCollision (coll.gameObject.collider2D, gameObject.collider2D);
				}
		}*/
}

