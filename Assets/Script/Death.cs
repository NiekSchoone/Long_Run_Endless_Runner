using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	private float death = -5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y < death)
		{
			Application.LoadLevel ("Main");
		}
	}
}
