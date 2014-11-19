using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public int golesA;
	public int golesB;
	float horizontal = 0f;
	float vertical = 0f;
	public bool tiro = false;
	//float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.Space) && tiro == true){
			rigidbody2D.AddForce (new Vector2 (rigidbody2D.velocity.x * 300, rigidbody2D.velocity.y * 300));
			tiro = false;
		}
	}

	void sumarA(){
		golesA++;
		}
	void sumarB(){
		golesB++;
		}
		
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player"){
			tiro = true;
				}
		if (coll.gameObject.tag == "GolA") {
						sumarA ();
				}
		if (coll.gameObject.tag == "GolB") {
						sumarB ();
				}
		}
	void OnTriggerExit2D(Collider2D coll){
				if (coll.gameObject.tag == "Player") {
						tiro = false;
				}
		}

}

