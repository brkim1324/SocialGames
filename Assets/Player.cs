using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	
	// Use this for initialization
	void Start ()
	{
		Rigidbody rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(0f,0f,0.3f);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(0f,0f,-0.3f);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(-0.3f,0,0f);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(0.3f,0f,0f);
		}

		if (Input.GetKey(KeyCode.Space))
		{
			
		}
	}
}
