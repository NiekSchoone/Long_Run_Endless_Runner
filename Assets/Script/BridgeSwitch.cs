using UnityEngine;
using System.Collections;

public class BridgeSwitch : MonoBehaviour 
{
	private bool switchingUp = false;
	private bool switchingDown = false;


	// Use this for initialization
	void Start () 
	{
		this.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown("down") && switchingDown == false && switchingUp == false)
		{
			if (transform.localEulerAngles.z <= 15) 
			{
				switchingDown = true;
			}
		}
		if (Input.GetKeyDown("up") && switchingUp == false && switchingDown == false) 
		{
			if (transform.localEulerAngles.z <= 345)
			{
				switchingUp = true;
			}
		}

		if (transform.localEulerAngles.z == 345) 
		{
			switchingUp = false;
		} 
		else if(switchingUp)
		{
			transform.Rotate(0,0,-1);
		}
		if (transform.localEulerAngles.z >= 15) 
		{
			switchingDown = false;
		}
		else if(switchingDown)
		{
			transform.Rotate(0,0,1);
		}
	}
}

