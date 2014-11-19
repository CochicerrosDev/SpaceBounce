using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public int golesA;
	public int golesB;
	float horizontal = 0f;
	float vertical = 0f;
	//float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void diparo(int speed1){
				rigidbody2D.AddForce (new Vector2 (rigidbody2D.position.x, rigidbody2D.position.y * speed1) * 10);
		}

	void sumarA(){
		golesA++;
		}
	void sumarB(){
		golesB++;
		}
		
	void OnTriggerEnter2D(Collider2D coll){
				if (coll.gameObject.tag == "GolA") {
						sumarA ();
				}
				if (coll.gameObject.tag == "GolB") {
						sumarB ();
				}
		}


}

