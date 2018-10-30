using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_two : MonoBehaviour
{

	public static int pinkStress;
	private float pinkSpeed;
	public Transform pink;
	public Transform pinkWork;
	public Transform pinkStreet;
	public Transform pinkHome;
	public float speed = 1f;

	public GameObject work;

	public Transform chicken;
	public float pinkIncome;


	// Use this for initialization
	void Start()
	{
		pinkStress = 0;
		

	}

	// Update is called once per frame
	void Update()
	{
		// STEP 1: define a Ray...
		// *not* Vector3.forward, that's the WORLD'S forward
		// transform.forward = this object's current forward
		
		Vector3 targetDir = pinkWork.position - transform.position;

		if (pinkStress <= 40)
		{
			Vector3 newDir = Vector3.RotateTowards(transform.forward, pinkWork.position,  speed, 0f);
			transform.position = Vector3.MoveTowards(transform.position, pinkWork.position, 0.2f * speed);
		}


		if (Vector3.Distance(transform.position, pinkWork.position) <= 5.0f)
		{
			
			
			//Destroy(work);
			pinkStress = pinkStress + 45;
			pinkIncome = pinkIncome + 10;

		}

		if (pinkStress >= 40)
		{
			float random = Random.Range(0.0f, 1.0f);
			if (random <= 0.5f)
			{
				Vector3 newDir = Vector3.RotateTowards(transform.forward, pinkWork.position,  speed, 0f);
				transform.position = Vector3.MoveTowards(transform.position, pinkHome.position, 0.2f * speed);
				
			}
			if(random > 0.5f)
			{
				Vector3 newDir = Vector3.RotateTowards(transform.forward, pinkWork.position,  speed, 0f);
				transform.position = Vector3.MoveTowards(transform.position, pinkStreet.position, 0.2f * speed);
			}
		}

		



		//pinkStress goes down
		

		//pink movement speed
		float pinkStep = pinkSpeed * Time.deltaTime;

		//pink goes to eat chicken and reduces stress
		if (pinkStress >= 50)
		{
			pink.transform.position = Vector3.MoveTowards(transform.position, chicken.position, pinkStep);
		}

		//pink eats food
		if (Vector3.Distance(pink.position, chicken.position) <= 6f)
		{
			pinkStress -= 20;
		}



	}

	

		private void previousupdate()
		{
			Ray eyeRay = new Ray(transform.position, transform.forward);

			// STEP 2: figure out a max distance?
			float maxRaycastDist = 1f;

			// STEP 3: (optional) visualize the raycast
			Debug.DrawRay(eyeRay.origin, eyeRay.direction * maxRaycastDist, Color.cyan);

			// STEP 4: shoot the raycast
			if (Physics.Raycast(eyeRay, maxRaycastDist))
			{
				// if it returns true, there's a wall, so we should turn randomly
				int randomNumber = Random.Range(0, 100);
				// if less than 50, turn left; otherwise, turn right
				if (randomNumber < 50)
				{
					transform.Rotate(0f, -90f, 0f);
				}
				else
				{
					transform.Rotate(0f, 90f, 0f);
				}
			}
			else
			{
				// go forward if raycast is FALSE (if there is no wall in front of us)
				transform.Translate(0f, 0f, Time.deltaTime);
			}
		}


	
}

