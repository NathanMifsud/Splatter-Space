using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour {

	public float bulletDespawnTime = 4f; 
	public Color playerColor;

	// Use this for initialization
	void Start(){

		Destroy (this.gameObject, bulletDespawnTime);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {


		if (col.gameObject.tag == "Planet") {
			
			col.GetComponent<Paint_Planet> ().PaintPlanet (playerColor); 
			Destroy (this.gameObject);
		}
		  

	}
}
