using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void OnGUI()
	{
		if (GUI.Button (new Rect(173, 364, 200, 100), "")) 
		{
			audio.Play();
			Application.LoadLevel("Main");
		}

				
				
	}
}
