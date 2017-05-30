using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paint_Planet : MonoBehaviour {

	//Renderer to access 'Color' and rend'
	Renderer rend;

	//Counter for blue player's score
	public int countBlue;
	//Counter for red player's score
	public int countRed;
	//Color of the planets if red player shoots it
	public Color blueColorScore;
	//Color of the planets if red player shoots it
	public Color redColorScore;
	//Color of the planets at the start of the game
	public Color currentColor;
	//Text output for red's score
	public Text redScore;
	//Text output for blue's score
	public Text blueScore;

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
		if (rend.material.color == currentColor) {
			rend.material.color = playerColor;
			if (playerColor == Color.red) {
				countRed++;
				redScore.text = countRed.ToString();
			}
			if (playerColor == Color.blue) {
				countBlue++;
				blueScore.text = countBlue.ToString ();
			}
		}
		
		if (rend.material.color != playerColor) {

			rend.material.color = playerColor;
				if (playerColor == Color.red) {
					
				countRed++;
				countBlue--;
				redScore.text = countRed.ToString();
				blueScore.text = countBlue.ToString();
				}
			if (playerColor == Color.blue) {

				countRed--;
				countBlue++;
				redScore.text = countRed.ToString();
				blueScore.text = countBlue.ToString();
			}
		}





	}
}
