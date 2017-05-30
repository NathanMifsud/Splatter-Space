using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour {

	public int countBlue;
	public int countRed;
	public Color blueColorScore;
	public Color redColorScore;
	Renderer rend;
	public Text redScore;
	public Text blueScore;

	// Use this for initialization
	void Start () {

		blueColorScore = Color.blue;
		redColorScore = Color.red;
		rend = GetComponent<Renderer> ();
		rend.enabled = true;



	}
	
	// Update is called once per frame
	void Update () {

		if (rend.material.color == redColorScore ) {


			countRed++;
			redScore.text = countRed.ToString();


		}



	}
}
