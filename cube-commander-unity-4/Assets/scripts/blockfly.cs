using UnityEngine;
using System.Collections;

public class blockfly : MonoBehaviour {

	public int movespeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.LeftArrow)) {
			//print ("LEFT");
			//print ("center rotation = " + CenterPieces.transform.eulerAngles);
			transform.Translate (-movespeed * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			//print ("RIGHT");
			//print ("center rotation = " + CenterPieces.transform.eulerAngles);
			transform.Translate (movespeed * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			//	print ("UP");
			//print ("center rotation = " + CenterPieces.transform.eulerAngles);
			transform.Translate (0, movespeed * Time.deltaTime, 0);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			//print ("DOWN");
			//print ("center rotation = " + CenterPieces.transform.eulerAngles);
			transform.Translate (0, -movespeed * Time.deltaTime, 0);
		}

	}
}
