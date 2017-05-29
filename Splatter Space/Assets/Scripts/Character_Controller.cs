using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class Character_Controller : MonoBehaviour {

	//Bullets
	public GameObject bullet;
	public GameObject bulletSpawnPoint1;
	public GameObject bulletSpawnPoint2;
	public float timeBetweenShots = .4f;
	public bool canShoot = true;

	//Bombs
	public GameObject bomb;
	public GameObject bombSpawn;
	public float timeBetweenBombs;
	public bool canBomb = true;

	//Controls
	public XboxController controller;

	public float constantThrust = 50f;

	public float boosterThrust = 200f;


	public float inputLeftStickY;
	public float inputLeftStickX;

	public float inputRightStickY;
	public float inputRightStickX;

	public float pitchSpeed = 5f;
	public float rollSpeed = 5f;
	public float yawSpeed = 5f;


	// Update is called once per frame
	void Update () {

		inputLeftStickY = (XCI.GetAxis (XboxAxis.LeftStickY, controller));
		inputLeftStickX = (XCI.GetAxis (XboxAxis.LeftStickX, controller));
		inputRightStickX = (XCI.GetAxis (XboxAxis.RightStickX, controller));

		MovePlayer ();
		PlayerShoot ();

	}

	private void MovePlayer(){
		

		transform.position += transform.forward * constantThrust * Time.deltaTime;

		if (XCI.GetAxis (XboxAxis.LeftTrigger, controller) !=0) { 

			transform.position += transform.forward * boosterThrust * Time.deltaTime;
		}

		if (inputLeftStickY < 0) {
			transform.Rotate ((inputLeftStickY) * pitchSpeed, 0, 0);
		}

		if (inputLeftStickY > 0) {
			transform.Rotate ((inputLeftStickY) * pitchSpeed, 0, 0);
		}

		if (inputRightStickX < 0) {
			transform.Rotate ((inputLeftStickX) * 0, 0, rollSpeed);
		}

		if (inputRightStickX > 0) {
					transform.Rotate ((inputLeftStickX) * 0, 0, -rollSpeed);
		}

		if (inputLeftStickX < 0) {
			transform.Rotate ((inputRightStickX) * 0, -yawSpeed, 0);
		}

		if (inputLeftStickX > 0) {
			transform.Rotate ((inputRightStickX) * 0, yawSpeed, 0);
		}






	}

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


		private void ResetShootBool(){
			canShoot = true;
		}



	private void ResetBombBool(){
		canBomb = true;
	}


	}



