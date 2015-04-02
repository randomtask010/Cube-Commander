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
		print("First point that collided: " + col.contacts[0].point);

		//print("Points colliding: " + col.contacts.Length);
		//print("Second point that collided: " + col.contacts[1].point);

		//Calculate where new block has to be created
		int newx = 0;
		int newy = 1;

		// On collision clone a new block
		Instantiate(block, new Vector2(newx, newy), Quaternion.identity);

		// Find block and set parent to Centerpieces object
		GameObject block2 = GameObject.Find("block(Clone)");
		block2.transform.parent = CenterPieces.transform;
		//name of cloned block must be block not block(clone) so this fixes it
		block2.name = block.name;

		//Destroy falling block on collision
		Destroy(col.gameObject);
	}
}
		