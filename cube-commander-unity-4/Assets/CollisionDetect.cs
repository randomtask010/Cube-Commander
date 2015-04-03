using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollisionDetect : MonoBehaviour {

	public Transform block;
	public Transform CenterPieces;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}


	// OnCollisionEnter2D is used to detect collision on objects WHICH MUST HAVE -->> Rigidbody 2D and box Colider 2D components
	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log("I'm working!");

		print("Points colliding: " + col.contacts.Length);
		print("First point that collided: x =" + col.contacts[0].point[0] + " y = " + col.contacts[0].point[1]);
		//Calculate where new block has to be created
		// center of new block depends on angle of centerPiece
		float x1 = col.contacts [0].point [0];
		float y1 = col.contacts [0].point [1];
		//float angle = Mathf.Atan2 (x1, y1) - Mathf.PI/4.0F;
		float degree = CenterPieces.transform.eulerAngles[2] ;
		// only need tilt of side so do modulus 90
		//degree = degree % 90;
		// convert angle to radians Math.PI * degrees / 180.0
		float angle = degree * Mathf.PI / 180F;
		print ("Angle = " + degree + " degrees " + angle + " radians");
		//float radius = Mathf.Sqrt (x1 * x1 + y1 * y1);
		// test if 2 point touching
		// check about quadrant
		float xx=0f;
		float yy=0f;
		float dl = Mathf.Sqrt (0.52F);
// slight left turn
		if (degree < 45F) {
			degree = 45f - degree;
			angle = degree * Mathf.PI / 180F;
			xx = x1 - dl * Mathf.Cos (angle);
			yy = y1 + dl * Mathf.Sin (angle);
		}
		else if (degree < 90F) {
			degree = 90F - degree;
			angle = degree * Mathf.PI / 180F;
			xx = x1 - dl * Mathf.Cos (angle);
			yy = y1 + dl * Mathf.Sin (angle);
		}
		else if (degree < 135F) {
			degree = 90F - degree;
			angle = degree * Mathf.PI / 180F;
			xx = x1 - dl * Mathf.Cos (angle);
			yy = y1 + dl * Mathf.Sin (angle);
		}
		else if (degree < 180F) {
			degree = 90F - degree;
			angle = degree * Mathf.PI / 180F;
			xx = x1 - dl * Mathf.Cos (angle);
			yy = y1 + dl * Mathf.Sin (angle);
		}
		else if ( degree < 225F) {
			degree = degree - 270F;
			angle = degree * Mathf.PI / 180F;
			xx = x1 + dl * Mathf.Cos (angle);
			yy = y1 + dl * Mathf.Sin (angle);
		}
		else if ( degree < 270F) {
			degree = degree - 270F;
			angle = degree * Mathf.PI / 180F;
			xx = x1 + dl * Mathf.Cos (angle);
			yy = y1 + dl * Mathf.Sin (angle);
		}
		else if ( degree < 315F) {
			degree = degree - 270F;
			angle = degree * Mathf.PI / 180F;
			xx = x1 + dl * Mathf.Cos (angle);
			yy = y1 + dl * Mathf.Sin (angle);
		}
		// slight right turn
		else {
			degree = degree - 315F;
			angle = degree * Mathf.PI / 180F;
			xx = x1 + dl * Mathf.Cos (angle);
			yy = y1 + dl * Mathf.Sin (angle);
		}
		print ("x = " + xx + " y = " + yy);


		//print("Points colliding: " + col.contacts.Length);
		//print("Second point that collided: " + col.contacts[1].point);


		// On collision clone a new block
		Instantiate(block, new Vector2(xx, yy), CenterPieces.transform.rotation);

		// Find block and set parent to Centerpieces object
		GameObject block2 = GameObject.Find("block(Clone)");
		block2.transform.parent = CenterPieces.transform;
		//name of cloned block must be block not block(clone) so this fixes it
		block2.name = block.name;

		//Destroy falling block on collision
		Destroy(col.gameObject);
	}
}
		