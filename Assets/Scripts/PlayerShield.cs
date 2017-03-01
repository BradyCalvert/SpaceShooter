using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour {

	public int numShields = 4;
	public GameObject shieldObject;
	public KeyCode shieldKey;
	public bool shieldActive;

	void Update () {
    //Is player pressing sheildKey?
    if (Input.GetKeyDown(shieldKey) && numShields > 0 && shieldActive!=true)
		{
      //Create a new shield object
      //Store the object in a variable
      GameObject tempShield= Instantiate(shieldObject, transform.position,Quaternion.identity);

			//Make the shield object a child of the ship
			tempShield.transform.SetParent(gameObject.transform);

      //set shieldActive to true
      //shieldActive = true;

			//shieldActive = true;
      numShields--;


		}
	}
}
