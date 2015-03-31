using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	int spinspeed = 200;

	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("a")) {
			print ("LEFT");
			transform.Rotate (0, 0, spinspeed * Time.deltaTime);
		}

		if (Input.GetKey ("d")) {
			print ("RIGHT");
			transform.Rotate (0, 0, -spinspeed * Time.deltaTime);
		}
	
	}
}
