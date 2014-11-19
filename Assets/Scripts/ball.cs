using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public int golesA;
	public int golesB;
	public bool movimientoActivado = false;

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
		movimientoActivado = false;
		StartCoroutine(ComenzarPartida(3.0F));
	}


}

