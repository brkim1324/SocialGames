using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pinkStress : MonoBehaviour
{

	// Use this for initialization


	 // The player's score.


	public Text uitext;



	void Awake()
	{
// Set up the reference.


// Reset the score.
		
	}


	void Update()
	{






// Set the displayed text to be the word "Score" followed by the score value.
		uitext.text = "Pink Stress Level " + npc_two.pinkStress;

	}

}