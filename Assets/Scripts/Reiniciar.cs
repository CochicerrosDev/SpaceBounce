using UnityEngine;
using System.Collections;

public class Reiniciar : MonoBehaviour { 

	public GameObject jugador1 = null;
	public GameObject jugador2 = null;
	public GameObject bola = null; 

	void OnTriggerEnter2D(Collider2D collider){
		 if (collider.gameObject.tag == "GolA" || collider.gameObject.tag == "GolB") {
			jugador1.gameObject.transform.position = new Vector3(-6.640419f,0f,0f);
			jugador1.rigidbody2D.velocity = new Vector3(0f,0f,0f);
			jugador2.gameObject.transform.position = new Vector3(6.508911f,0f,0f);
			jugador2.rigidbody2D.velocity = new Vector3(0f,0f,0f);
			bola.gameObject.transform.position = new Vector3(0f,0f,0f);
			bola.rigidbody2D.velocity = new Vector3(0f,0f,0f);
		}
	}
}
