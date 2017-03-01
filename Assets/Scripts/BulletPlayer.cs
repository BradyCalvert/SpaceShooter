using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour {

	public float destroyTime;
	public float bulletSpeed=10;
	public GameObject explosion;
	public SoundManager soundManager;
	public AudioClip hitEnemy;
  //public PlayerHealth score;
	

	// Use this for initialization
	void Start () {
		//Destroy the bullet after destroyTime
		Destroy(gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		//Move the bullet in tehf orward direction,at speed bulletSpeed,with frame-rate independence
		transform.Translate(Vector3.forward*bulletSpeed*Time.deltaTime);
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.transform.CompareTag("Enemy")==true)
		{
      //is something stored in teh explosion?
      if (explosion != null) 
			{
				Instantiate (explosion, transform.position, Quaternion.identity);
				//mke sound
				//sfx
			}
			Destroy (this.gameObject);
		}
	}

}
