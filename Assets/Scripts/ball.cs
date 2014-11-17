using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	int golesA;
	int golesB;


	// Use this for initialization
	void Start () {
	
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
		}

}
