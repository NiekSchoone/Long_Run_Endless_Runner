using UnityEngine;
using System.Collections;

public class ssparkScript : MonoBehaviour {


	// Use this for initialization
	void OnTriggerEnter(Collider other){
		if(other == true)
		{
			particleEmitter.emit = true;
		}
	}

	void OnTriggerExit(Collider other){
		if(other == true)
		{
			particleEmitter.emit = false;
		}

	}
}
