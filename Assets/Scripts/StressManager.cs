using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StressManager : MonoBehaviour {
	public static float score;        // The player's score.
	//public static float income;


	public Text uitext;  
	
	
	
	void Awake ()
	{
		// Set up the reference.
		

		// Reset the score.
		score = 0;
	}
	
	
	void Update () {
                   


	


		// Set the displayed text to be the word "Score" followed by the score value.
		uitext.text = "My Stress Level " + score;
		//uitext.text = "\nIncome:" + income;

	}
}
