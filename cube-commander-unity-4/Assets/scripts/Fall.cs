using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	int fallspeed = 1;

	// Update is called once per frame
	void Update () {
		transform.Translate (0, -fallspeed * Time.deltaTime, 0);

		if (transform.position.y <= 0) {
			transform.Translate (0, 6, 0);
		}
	}
}
