﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paint_Planet : MonoBehaviour {

	//Renderer to access 'Color' and rend'
	Renderer rend;

	//True if planet is Red
	public bool isRed = false;
	//True if planet is Blue
	public bool isBlue = false;
	//Color of the planets if red player shoots it
	public Color blueColorScore;
	//Color of the planets if red player shoots it
	public Color redColorScore;
	//Color of the planets at the start of the game
	public Color currentColor;



	private GameController controller;


	//----------------------------------------------------------------------
	//		Start()
	// Runs on play
	// 
	// Param:			
	// 			None
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	void Start () {
		//Cache game controller
		controller = FindObjectOfType<GameController>();
	
		rend = GetComponent<Renderer> ();
		rend.enabled = true;


	}

	//----------------------------------------------------------------------
	//		PaintPlanet()
	// Paints the planets dependants 
	// 
	// Param:			
	// 			None
	// Return:
	// 			
	//----------------------------------------------------------------------


	public void PaintPlanet(Color playerColor) {
		//debugColor = rend.material.color;
		if (rend.material.color == currentColor) {
			rend.material.color = playerColor;
			if (playerColor == Color.red) {
				Debug.Log ("HERE RED");
				isRed = true;
				isBlue = false;
				controller.AddScore (1, Color.red);

			}
			if (playerColor == Color.blue) {
				isRed = false;
				isBlue = true;
	
				controller.AddScore (1, Color.blue);

			}
		}else{//If the planet is not the same colour as the current colour
			Debug.Log("WE HERE MAYBE?");
		}
		
		if (rend.material.color == Color.blue) {

			rend.material.color = playerColor;
			if (playerColor == Color.red) {
				controller.AddScore (1, Color.red);
				controller.RemoveScore (1, Color.blue);

				isRed = true;
				isBlue = false;

			}
		}

		if (rend.material.color == Color.red) {
			rend.material.color = playerColor;
			if (playerColor == Color.blue) {
				controller.AddScore (1, Color.blue);
				controller.RemoveScore (1, Color.red);
				isRed = false;
				isBlue = true;
		
			}
		}

		if (rend.material.color != playerColor) { //If not same as player
			if(rend.material.color == currentColor){ //is it the planet colour?
				//Is green
				//What colour is polayer shooting
				//Add score to that player

			}else{
				//is other player
				//remove score from other player
				//addd score to this player
			}
		
		}
		//If planet is already red





	}
}
