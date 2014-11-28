using UnityEngine;
using System.Collections;

public class SwitchPoint : MonoBehaviour {

	public BridgeSwitch bridgeSwitch;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider trig)
	{
		if (trig.gameObject.tag == "Player") 
		{
			Debug.Log("pull the lever!!!");
			bridgeSwitch.enabled = true;
		}
	}
}
