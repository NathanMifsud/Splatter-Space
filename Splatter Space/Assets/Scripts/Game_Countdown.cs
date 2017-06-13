using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Countdown : MonoBehaviour {

	public float gameTimer = 90f;
	public Text gameCountDown;


	
	// Update is called once per frame
	void Update () {

		gameCountDown.text = gameTimer.ToString ();
		gameTimer -= Time.deltaTime;

		if (gameTimer <= 0) {
		
			gameTimer = 0f;
		
		
		}


	}
}
