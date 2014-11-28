using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void OnGUI()
	{
		if (GUI.Button (new Rect(Screen.width / 2 - 100, Screen.height / 2 - 40, 200, 80), "Start")) 
		{
			audio.Play();
			Application.LoadLevel("Main");
		}

				
				
	}
}
