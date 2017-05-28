using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint_Planet : MonoBehaviour {

	public Material[] material;
	Renderer rend;


	void Start () {

		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];

	}

	// Update is called once per frame

	void PaintPlanet (Collider col) {
		if (col.gameObject.tag == "Bullet") {
			rend.sharedMaterial = material [1];
		}


	}
}
