using UnityEngine;
using System.Collections;

public class Fallx : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	int fallspeed = 1;

	// Update is called once per frame
	void Update () {
		transform.Translate (-fallspeed * Time.deltaTime, 0, 0);

		if (transform.position.x <= 0) {
			transform.Translate (6, 0, 0);
		}
	}
}
