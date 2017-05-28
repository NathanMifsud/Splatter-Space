using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour {

	public float bulletDespawnTime = 4f; 

	// Use this for initialization
	void Start(){

		Destroy (this.gameObject, bulletDespawnTime);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {

		if (col.gameObject.tag == "Planet") {
		Invoke ("Paint_Planet", 1);
			Destroy (this.gameObject);
		}


	}
}
