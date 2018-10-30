using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBehavior : MonoBehaviour
{

	public static float blueStress;
	public Transform blueHome;
	public Transform playerHome;
	public float speed = 0.2f;
	
	public Transform pinkHome;
	private bool notStressed;
	
	// Use this for initialization
	void Start ()
	{
		blueStress = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{

		blueStress += 0.1f;
		

			
			if (blueStress >= 50)
			{
				float n = Random.Range(0f, 1f);
				if (n <= 0.5f)
				{
					PlayerH();

				}

				if (n >= 0.5f)
				{
					pinkH();
				}

				else
				{
					transform.position = Vector3.MoveTowards(transform.position, blueHome.position, speed);
					
				}
				
			}
		}

		
	

	public void PlayerH()
	{
		float newSpeed = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.forward, playerHome.position, speed);
		if (Vector3.Distance(transform.position, playerHome.position) <= 3.0f)
		{
			blueStress -= 0.1f;
			Player.playerStress += 0.5f;

			if (blueStress <= 40)
			{
				transform.position = Vector3.MoveTowards(transform.position, blueHome.position, speed);
			}
		}
			
		
	}

	public void pinkH()
	{
		transform.position = Vector3.MoveTowards(transform.forward, pinkHome.position, speed);
		
		if (Vector3.Distance(transform.position, playerHome.position) <= 3.0f)
		{
			blueStress -= 0.1f;
			npc_two.pinkStress += 0.5f;
		}
		
		else if (blueStress <= 40)
		{
			transform.position = Vector3.MoveTowards(transform.position, blueHome.position, speed);
		}
	}

	public void Idle()
	{
		notStressed = true;
	}
}
