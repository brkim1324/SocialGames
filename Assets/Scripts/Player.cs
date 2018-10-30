using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float playerStress;
	public float moveSpeed = 0.1f;
	public Transform player;
	public Transform tv;
	private float coolDown;
	
	// Use this for initialization
	void Start ()
	{
		Rigidbody rb = GetComponent<Rigidbody>();
		playerStress = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(0f,0f,moveSpeed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(0f,0f,-moveSpeed);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(-moveSpeed,0,0f);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(moveSpeed,0f,0f);
		}

		
		//FIGURE OUT WHAT TO DO WITH SPACE
		if (Input.GetKey(KeyCode.Space))
		{
			
		}

		playerStress += Time.deltaTime;

		
		if (playerStress >= 100)
		{
			float newSpeed = moveSpeed;
			newSpeed = 0.1f;
		}

		if (Vector3.Distance(player.position, tv.position) <= 6f)
		{
			playerStress -= 20;
		}

		

	}
}
