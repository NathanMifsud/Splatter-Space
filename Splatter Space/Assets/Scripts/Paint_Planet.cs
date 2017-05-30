using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paint_Planet : MonoBehaviour {

	Renderer rend;

	public int countBlue;
	public int countRed;
	public Color blueColorScore;
	public Color redColorScore;
	public Color currentColor;
	public Text redScore;
	public Text blueScore;


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
	// Return;
	// 			Void
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
