using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{

	public float playerStress;
	public static int pinkStress;
	public static float blueStress;

	
	public GameObject player;
	public Transform pink;
	public GameObject blue;
	public Transform chicken;
	public Transform tv;

	public float pinkSpeed;
	
	
	
	
	public 
	
	// Use this for initialization
	void Start ()
	{
		playerStress = 100;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		pinkStress -= 1 ;
		
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
}
