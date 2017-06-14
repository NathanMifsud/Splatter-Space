using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour {

	//Despawn time for bullets
	public float bulletDespawnTime = 4f; 
	//Color of the bullets, used to change the color of the planets
	public Color playerColor;

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

		Destroy (this.gameObject, bulletDespawnTime);
	}


	//----------------------------------------------------------------------
	//		OnTriggerEnter()
	// Triggers the Painting script and deletes the projectile
	// 
	// Param:			
	// 		Collider col - The collider of any objects that pass into this trigger	
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	void OnTriggerEnter (Collider col) {


		if (col.gameObject.tag == "Planet") {
			
			col.GetComponent<Paint_Planet> ().PaintPlanet (playerColor); 
			Destroy (this.gameObject);
		}
		  

	}
}
