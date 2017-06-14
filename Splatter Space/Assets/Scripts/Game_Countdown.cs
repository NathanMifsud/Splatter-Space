using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Countdown : MonoBehaviour {

	//Amount of time per match
	public float gameTimer = 90f;
	//Text output for game time
	public Text gameCountDown;


	
	//----------------------------------------------------------------------
	//		Update()
	// Runs every frame
	// 
	// Param:			
	// 			None
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	void Update () {

		gameCountDown.text = gameTimer.ToString ();
		gameTimer -= Time.deltaTime;

		if (gameTimer <= 0) {
		
			gameTimer = 0f;
		
		
		}


	}
}
