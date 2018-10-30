using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueStress : MonoBehaviour {

	// Use this for initialization
	public Text uitext;



	void Awake()
	{
// Set up the reference.


// Reset the score.
		
	}


	void Update()
	{






// Set the displayed text to be the word "Score" followed by the score value.
		uitext.text = "Blue Stress Level " + BlueBehavior.blueStress;

	}
}
