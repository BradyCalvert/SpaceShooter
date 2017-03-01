using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldHealth : MonoBehaviour {

	public int shieldStrength = 3;

	void OnTriggerEnter(Collider other)
	{

		//Debug.Log("Collision Happened with:" + other.gameObject.name);
		//Did enemy or enemy bullet just hit me?
		if(other.CompareTag("Enemy") || other.CompareTag("EnemyBullet"))
		{
			//Reduce strength by 1
			shieldStrength--;
		}
			//Is shield out of strength?
		if(shieldStrength<=0)
		{
			//Deactivate shield


			//go to PlayerShield
			//call the shieldActive method
			GetComponentInParent<PlayerShield>().shieldActive=false;



			//Destroy this object
			Destroy(gameObject);
		}
	}
}
