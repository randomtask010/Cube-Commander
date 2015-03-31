using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {
	
	public Transform block;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log("I'm working!");	
		//	Instantiate(block, new Vector2(0, 1), Quaternion.identity);
		Transform child = Instantiate(block, new Vector2 (0,1), Quaternion.identity) as Transform; 
		child.parent = block.GetComponent <Transform>();
		Destroy(col.gameObject);
	}
}
		