using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour	
{
	private float _jumpForce = 	5f;
	public bool _isJumping	=	false;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			if(_isJumping == false)
			{
				rigidbody.velocity = transform.up * _jumpForce;
				//rigidbody.AddForce(Vector3.up * _jumpForce);
				_isJumping = true;
			}
		}
		/*	
		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			transform.localScale -= Vector2(0,0.5f);
		}
		*/
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Platform")
		{
			_isJumping = false;

		}
		/*if (col.gameObject.tag == "Obstacle") 
		{
			Debug.Log("You died!");
			Destroy(this.gameObject);
		}*/
	}
}

