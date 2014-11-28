using UnityEngine;
using System.Collections;

public class sparkLight : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other == true)
		{
			light.intensity = 2;
		}
	}
	
	void OnTriggerExit(Collider other){
		if(other == true)
		{
			light.intensity = 0;
		}
		
	}
}
