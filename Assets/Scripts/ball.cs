using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public int golesA;
	public int golesB;
<<<<<<< HEAD
	public bool movimientoActivado = false;
=======
	float horizontal = 0f;
	float vertical = 0f;
	public bool tiro = false;
	//float speed = 1f;
>>>>>>> 99500922e249b8b6edd21f26a98411ffccd9fc3e

	// Use this for initialization
	void Start () {
		StartCoroutine(ComenzarPartida(3.0F));
	}

	IEnumerator ComenzarPartida (float segundos) {
		yield return new WaitForSeconds (segundos);
		movimientoActivado = true;
		Debug.Log ("he esperado los segundos");
	}

	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		
=======
		if(Input.GetKey (KeyCode.Space) && tiro == true){
			rigidbody2D.AddForce (new Vector2 (rigidbody2D.velocity.x * 300, rigidbody2D.velocity.y * 300));
			tiro = false;
		}
>>>>>>> 99500922e249b8b6edd21f26a98411ffccd9fc3e
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
<<<<<<< HEAD
		movimientoActivado = false;
		StartCoroutine(ComenzarPartida(3.0F));
	}

=======
		}
	void OnTriggerExit2D(Collider2D coll){
				if (coll.gameObject.tag == "Player") {
						tiro = false;
				}
		}
>>>>>>> 99500922e249b8b6edd21f26a98411ffccd9fc3e

}

