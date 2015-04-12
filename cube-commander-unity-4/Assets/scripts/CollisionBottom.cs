using UnityEngine;
using System.Collections;

public class CollisionBottom : MonoBehaviour {

	public Transform block;
	public Transform CenterPieces;

	// Use this for initialization
	void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		print ("Collision Bottom");
		Destroy(col.gameObject);

		// calculate location of new block, adjusting for angle of centerpiece
		float degree = transform.eulerAngles[2] ;
		
		// subtract 90 degrees for this quadrant
		float angle = (degree-90F) * Mathf.PI / 180F;
		print ("Angle = " + degree + " degrees " + angle + " radians");
		
		float x = transform.position.x;
		float y = transform.position.y;
		float xx = x + 0.5F * Mathf.Cos (angle);
		float yy = y + 0.5F * Mathf.Sin (angle);

		// On collision clone a new block
		Transform objcol = (Transform)Instantiate(block, new Vector2(xx, yy), CenterPieces.transform.rotation);



		// Find block and set parent to Centerpieces object
		//GameObject block2 = GameObject.Find("block(Clone)");
		objcol.transform.parent = CenterPieces.transform;
		
		//name of cloned block must be block not block(clone) so this fixes it
		objcol.name = block.name;
		
		//change sprite of cloned block to one that collided
		objcol.GetComponent<SpriteRenderer>().sprite = col.gameObject.GetComponent<SpriteRenderer>().sprite;
		//i1=
		//i2= 
		//objgrid [i1, i2] = objcol;
	}
}	



