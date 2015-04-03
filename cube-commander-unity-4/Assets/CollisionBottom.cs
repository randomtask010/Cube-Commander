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
		print ("Collision Left");
		Destroy(col.gameObject);
		// calculate location of new block, adjusting for angle of centerpiece
		float degree = transform.eulerAngles[2] ;
		
		// aubtract 90 degrees for this quadrant
		float angle = (degree-90F) * Mathf.PI / 180F;
		print ("Angle = " + degree + " degrees " + angle + " radians");
		
		float x = transform.position.x;
		float y = transform.position.y;
		float xx = x + 0.5F * Mathf.Cos (angle);
		float yy = y + 0.5F * Mathf.Sin (angle);
		
		// On collision clone a new block
		Instantiate(block, new Vector2(xx, yy), CenterPieces.transform.rotation);
		// Find block and set parent to Centerpieces object
		GameObject block2 = GameObject.Find("block(Clone)");
		block2.transform.parent = CenterPieces.transform;
		
		//name of cloned block must be block not block(clone) so this fixes it
		block2.name = block.name;
	}
}



