using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public bool movimientoActivado = false;
	float horizontal = 0f;
	float vertical = 0f;
	bool freno = false;
	public float speed = 2f;
	public float aceleracion = 1f;
	GameObject[] ZonaNoo;
	public GameObject balon;

	void start(){
		
	}


	// Update is called once per frame
	void Update () {

		if ((movimientoActivado = balon.gameObject.GetComponent<ball>().movimientoActivado) == true) {
			horizontal = Input.GetAxis ("Horizontal");
			vertical = Input.GetAxis ("Vertical");
			freno = Input.GetKey (KeyCode.Space);
		}

		ZonaNoo = GameObject.FindGameObjectsWithTag ("ZonaNo");
		foreach (GameObject go in ZonaNoo) {
			Physics2D.IgnoreCollision (go.collider2D, collider2D);
		}

	}

	void FixedUpdate(){	
		rigidbody2D.AddForce (new Vector2( horizontal * speed,  vertical * speed) * aceleracion);

		if (freno) {
			rigidbody2D.AddForce (-rigidbody2D.velocity);
		}


	}

	/*void OnTriggerStay2D(Collider2D coll){
				if (coll.gameObject.tag == "Ball") {
						if (Input.GetKey (KeyCode.Space)) {
								coll.gameObject.SendMessage ("disparo", 1);
						}
				}
		}*/

	/*void OnCollisionEnter2D(Collision2D coll){
				if (coll.gameObject.tag == "ZonaNo") {
			Physics2D.IgnoreCollision (coll.gameObject.collider2D, gameObject.collider2D);
				}
		}*/
}

