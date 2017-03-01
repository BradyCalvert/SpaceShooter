using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float verticalSpeed;
	public float horizontalSpeed;
	public Boundry boundry;

	float startingZ;

	// Use this for initialization
	void Start () {

		startingZ = transform.position.z;

		//Set startingZ to the current Z position of th eobject
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//get verticle input from the keyboard adjust the speed and make it frame indepenet
		float verticalInput = Input.GetAxis ("Vertical") * verticalSpeed * Time.deltaTime;

		//get horizontal input from the keyboard adjust the speed and make it franme independent
		float horizontalInput = Input.GetAxis ("Horizontal") * horizontalSpeed * Time.deltaTime;


		// move the objext in the direction indicated by horizxontal and verticle speed
		transform.Translate(horizontalInput,verticalInput,0f); 


		//clamp the position so it cannot leave the screen
		Vector3 tempVector = transform.position;
		tempVector.x = Mathf.Clamp (tempVector.x, boundry.horizontalMin, boundry.horizontalMax);
		tempVector.y = Mathf.Clamp (tempVector.y, boundry.verticalMin, boundry.verticleMax);
		tempVector.z = startingZ;

		//long way
		/*if (transform.position.x < boundry.horizontalMin) 
		{
			Vector3 tempPos = transform.position;
			tempPos.x = boundry.horizontalMin;
			transform.position = tempPos;
		}*/

	}
}
