using UnityEngine;
using System.Collections;

public class SlowMoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Time.timeScale);
	}

	void OnTriggerStay(Collider slowMoCol)
	{
		if (slowMoCol.gameObject.tag == "SlowMo") 
		{
			if(Time.timeScale == 1.0f)
			{
				Debug.Log("Initiate slowmotion");
				Time.timeScale = 0.5f; 

			}else{
				Time.timeScale = 1.0f;
			}
			Time.fixedDeltaTime = Time.unscaledDeltaTime;

		}
	}
}
