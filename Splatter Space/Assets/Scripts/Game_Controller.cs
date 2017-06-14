using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour {

	//Text output for red's score
	public Text redScore;
	//Text output for blue's score
	public Text blueScore;
	//The Red counter
	public int redCounter;
	//The blue countr
	public int blueCounter;

	//----------------------------------------------------------------------
	//		Start()
	// Runs on play
	// 
	// Param:			
	// 			None
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	void Start(){
		UpdateScore ();
	}


	//----------------------------------------------------------------------
	//		AddScore()
	// Triggers the Painting script and deletes the projectile
	// 
	// Param:			
	// 		Collider col - The collider of any objects that pass into this trigger	
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	public void AddScore(int scoreToAdd, Color _color ){
		if(_color == Color.red){
			redCounter += scoreToAdd;
		}else if(_color == Color.blue){
			blueCounter += scoreToAdd;
		}
		UpdateScore ();
	}





	public void RemoveScore(int scoreToAdd, Color _color ){
		if(_color == Color.red){
			redCounter -= scoreToAdd;
		}else if(_color == Color.blue){
			blueCounter -= scoreToAdd;
		}
		UpdateScore ();
	}


	private void UpdateScore(){
		redScore.text = redCounter.ToString (); 
		blueScore.text = blueCounter.ToString ();
	}
}

	




