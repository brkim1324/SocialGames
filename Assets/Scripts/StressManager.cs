using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StressManager : MonoBehaviour {
	public static int score;        // The player's score.


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
	
	}
}
