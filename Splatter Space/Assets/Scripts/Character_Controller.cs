using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Character_Controller : MonoBehaviour {

	//Game Object for the bullet
	public GameObject bullet;
	//Left Bullet Spawnpoint
	public GameObject bulletSpawnPoint1;
	//Right Bullet Spawnpoint
	public GameObject bulletSpawnPoint2;
	//DelayedAttribute between shots fired
	public float timeBetweenShots = .4f;
	//Boolean used to reactivate the timer for shots
	public bool canShoot = true;

	//Game Object for the Bomb
	public GameObject bomb;
	//Bomd Spawnpoint
	public GameObject bombSpawn;
	//Cooldown for bombs fired;
	public float timeBetweenBombs;
	//Boolean used to reactivate the timer before bombs
	public bool canBomb = true;

	//Game Object for the Rear Camera
	public GameObject rearCamera;

	//Game Object for the ships
	public GameObject ship;
	//Xbox Controllers
	public XboxController controller;

	//Speed at which the ships move forward when no input
	public float constantThrust = 50f;

	//Speed at which the ship moves forward when boosted
	public float boosterThrust = 200f;

	//Controller inputs
	public float inputLeftStickY;
	public float inputLeftStickX;

	public float inputRightStickY;
	public float inputRightStickX;

	//Flying Controlls
	public float pitchSpeed = 5f;   
	public float rollSpeed = 5f;
	public float yawSpeed = 5f;


	//----------------------------------------------------------------------
	//		Update()
	// Runs every frame
	// 
	// Param:			
	// 			None
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	void Update () {

		inputLeftStickY = (XCI.GetAxis (XboxAxis.LeftStickY, controller));
		inputLeftStickX = (XCI.GetAxis (XboxAxis.LeftStickX, controller));
		inputRightStickX = (XCI.GetAxis (XboxAxis.RightStickX, controller));

		MovePlayer ();
		PlayerShoot ();

	}

	//----------------------------------------------------------------------
	//		MovePlayer()
	// Moves the player
	// 
	// Param:			
	// 			None
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	private void MovePlayer(){
		

		transform.position += transform.forward * constantThrust * Time.deltaTime;

		if (XCI.GetAxis (XboxAxis.LeftTrigger, controller) !=0) { 

			transform.position += transform.forward * boosterThrust * Time.deltaTime;
		}

		if (inputLeftStickY < 0) {
			transform.Rotate ((inputLeftStickY) * pitchSpeed * Time.deltaTime, 0, 0);
		}

		if (inputLeftStickY > 0) {
			transform.Rotate ((inputLeftStickY) * pitchSpeed * Time.deltaTime, 0, 0);
		}

		if (inputRightStickX < 0) {
			transform.Rotate ((inputLeftStickX) * 0, 0, rollSpeed * Time.deltaTime);
		}

		if (inputRightStickX > 0) {
			transform.Rotate ((inputLeftStickX) * 0, 0, -rollSpeed * Time.deltaTime);
		}

		if (inputLeftStickX < 0) {
			transform.Rotate ((inputRightStickX) * 0, -yawSpeed * Time.deltaTime, 0);
		}

		if (inputLeftStickX > 0) {
			transform.Rotate ((inputRightStickX) * 0, yawSpeed * Time.deltaTime, 0);
		}

		if (XCI.GetButton(XboxButton.A, controller)) {

			rearCamera.SetActive (true);

		}
		if (XCI.GetButtonUp(XboxButton.A, controller)) {

			rearCamera.SetActive (false);

		}




	}
	//----------------------------------------------------------------------
	//		PlayerShoot()
	// Lets the player shoot normal bullet and bomb projectiles
	// 
	// Param:			
	// 			None
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	private void PlayerShoot(){




		if (XCI.GetAxis (XboxAxis.RightTrigger, controller) != 0) {
			
				if (canShoot == true) {
					GameObject Go = Instantiate (bullet, bulletSpawnPoint1.transform.position, transform.rotation) as GameObject;
					Go.GetComponent<Rigidbody> ().AddForce (transform.forward * 100, ForceMode.Impulse);
					GameObject Go2 = Instantiate (bullet, bulletSpawnPoint2.transform.position, transform.rotation) as GameObject;
					Go2.GetComponent<Rigidbody> ().AddForce (transform.forward * 100, ForceMode.Impulse);
					canShoot = false;
					Invoke ("ResetShootBool", timeBetweenShots);
				}
			}


		if (XCI.GetButtonDown (XboxButton.RightBumper, controller)) {

			if (canBomb == true) {
				GameObject Go3 = Instantiate (bomb, bombSpawn.transform.position, transform.rotation) as GameObject;
				Go3.GetComponent<Rigidbody> ().AddForce (transform.forward * 50, ForceMode.Impulse);
				canBomb = false;
				Invoke ("ResetBombBool", timeBetweenBombs);
			}
		}

	}

	//----------------------------------------------------------------------
	//		ResetShootBool()
	// Resets the boolean for the Shoot Timer
	// 
	// Param:			
	// 			None
	// Return;
	// 			Void
	//----------------------------------------------------------------------
		private void ResetShootBool(){
			canShoot = true;
		}


	//----------------------------------------------------------------------
	//		ResetBombBool()
	// Resets the boolean for the Bomb Timer
	// 
	// Param:			
	// 			None
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	private void ResetBombBool(){
		canBomb = true;
	}



	//----------------------------------------------------------------------
	//		ResetBombBool()
	// Destroys the players if they collide with eachother and respawns them
	// 
	// Param:			
	// 			Collider col - The collider of any objects that pass into this trigger
	// Return;
	// 			Void
	//----------------------------------------------------------------------
	void OnTriggerEnter (Collider col) {


		if (col.gameObject.tag == "Player") {


			Destroy (this.ship);
		}

	}


}
