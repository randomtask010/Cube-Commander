using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

	public AudioClip chime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void chimePlay () {
		audio.PlayOneShot (chime);
	}

}
