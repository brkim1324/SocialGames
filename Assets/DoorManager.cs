using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

	public Transform player;

	public Transform doorA;
	public Transform buttonA;

	public Transform doorB;

	public Transform buttonB;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Vector3.Distance(player.position, buttonA.position) < 5f)
		{
			doorA.Translate(0f, 5f, 0f);
		}

		if (Vector3.Distance(player.position, buttonB.position) < 6f)

		{
			doorB.Translate(0f, 5f, 0f);

		}
	}
}

