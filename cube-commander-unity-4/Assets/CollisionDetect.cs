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
		float angle = Mathf.Atan2 (x1, y1) - Mathf.PI/4.0F;
		//float radius = Mathf.Sqrt (x1 * x1 + y1 * y1);

		print ("angle = " + angle);
		float xx =  Mathf.Sin (angle) ;
		float yy =  Mathf.Cos (angle) ;
		print ("x = " + xx + " y = " + yy);

		//print ("center rotation = " + CenterPieces.transform.eulerAngles);

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
		