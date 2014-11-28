using UnityEngine;
using System.Collections;

public class Offscreen : MonoBehaviour {

	public float offscreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x < offscreen)
		{
			Destroy(gameObject);
		}
	}
}
