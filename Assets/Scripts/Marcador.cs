using UnityEngine;
using System.Collections;

public class Marcador : MonoBehaviour {

	int golesA = 0;
	int golesB = 0;
	public TextMesh marcadorA;
	public TextMesh marcadorB;
	public GameObject ball;


	// Update is called once per frame
	void Update () {
		golesA = ball.gameObject.GetComponent<ball>().golesA;
		golesB = ball.gameObject.GetComponent<ball>().golesB;

		marcadorA.text = golesA.ToString();
		marcadorB.text = golesB.ToString();
	}
}
