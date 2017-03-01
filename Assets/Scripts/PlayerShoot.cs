using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	public GameObject bullet;
	public Transform shootLocation;
	public SoundManager soundManager;
	public AudioClip shootSound;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if the player is pressing space
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			//create a new bullet object in a variable
			GameObject tempBullet = Instantiate (bullet, shootLocation.position, Quaternion.identity);

		

			

			//give that bullet object a reference to the sound manager
			tempBullet.GetComponent<BulletPlayer> ().soundManager = soundManager;


			//make a shooty sound


			soundManager.PlaySFX (shootSound);
		
		}
	}
}
