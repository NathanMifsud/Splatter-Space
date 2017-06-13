using System.Collections;
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



	private Game_Controller controller;


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
		controller = FindObjectOfType<Game_Controller>();
	
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
				isRed = true;
				isBlue = false;
				controller.AddScore (1, Color.red);

			}
			if (playerColor == Color.blue) {
				isRed = false;
				isBlue = true;
	
				controller.AddScore (1, Color.blue);

			}
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

	}
}
