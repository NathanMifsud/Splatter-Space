using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	//Text output for red's score
	public Text redScore;
	//Text output for blue's score
	public Text blueScore;
	public int redCounter;
	public int blueCounter;

	void Start(){
		UpdateScore ();
	}



//	// Update is called once per frame
//	void Update () {
//
//		foreach (GameObject go in GameObject.FindGameObjectsWithTag ("Planet")) {
//			Debug.Log ("Planets: " + go.name);
//			if (go.GetComponent<Paint_Planet> ().isRed == true) {
//
//				redCounter++;
//				redScore.text = redCounter.ToString();
//			
//			}
//			if (go.GetComponent<Paint_Planet> ().isBlue == true) {
//
//
//				blueCounter++;
//				blueScore.text = blueCounter.ToString();
//
//			}
//
//
//			}
//
//				
//	}

	//The player to add score to
	public void AddScore(int scoreToAdd, Color _color ){
		if(_color == Color.red){
			redCounter += scoreToAdd;
		}else if(_color == Color.blue){
			blueCounter += scoreToAdd;
		}
		UpdateScore ();
	}
	//_color = the player to remove score from
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

	




