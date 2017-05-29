using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint_Planet : MonoBehaviour {

	public Material[] material;
	Renderer rend;


	void Start () {

		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.material = material [0];

	}

	// Update is called once per frame

	public void PaintPlanet(Color playerColor) {

		rend.material.color = playerColor;


	}
}
