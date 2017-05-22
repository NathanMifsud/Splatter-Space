using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour {

	public GameObject bullet;
	public GameObject bulletSpawnPoint1;
	public GameObject bulletSpawnPoint2;

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.W))  {
			transform.position = transform.position + (transform.forward * 1f);
		}
		if (Input.GetKey (KeyCode.LeftArrow))  {
			transform.Rotate 	(new Vector3 (0, -1, 0));
		}
		if (Input.GetKey (KeyCode.RightArrow))  {
			transform.Rotate 	(new Vector3 (0, 1, 0));
		}
		if (Input.GetKey (KeyCode.A))  {
			transform.Rotate 	(new Vector3 (0, 0, 2));
		}
		if (Input.GetKey (KeyCode.D))  {
			transform.Rotate 	(new Vector3 (0, 0, -2));
		}
		if (Input.GetKey (KeyCode.DownArrow))  {
			transform.Rotate 	(new Vector3 (-0.9f, 0, 0));
		}
		if (Input.GetKey (KeyCode.UpArrow))  {
			transform.Rotate 	(new Vector3 (0.9f, 0, 0));
		}
		if (Input.GetKey (KeyCode.Space)) {
			GameObject Go = Instantiate (bullet, bulletSpawnPoint1.transform.position, transform.rotation) as GameObject;
			Go.GetComponent<Rigidbody> ().AddForce (transform.forward * 100, ForceMode.Impulse);

		}
		if (Input.GetKey (KeyCode.Space)) {
			GameObject Go = Instantiate (bullet, bulletSpawnPoint2.transform.position, transform.rotation) as GameObject;
			Go.GetComponent<Rigidbody> ().AddForce (transform.forward * 100, ForceMode.Impulse);

		}
	}
}
