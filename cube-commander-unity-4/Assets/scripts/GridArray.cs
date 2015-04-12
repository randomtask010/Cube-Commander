using UnityEngine;
using System.Collections;

public class GridArray : MonoBehaviour {
	
	public static int s = 10;
	public static Transform[,] grid = new Transform[2*s+1, 2*s+1];

	// Use this for initialization
	void Start () {
		print ("Test");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
