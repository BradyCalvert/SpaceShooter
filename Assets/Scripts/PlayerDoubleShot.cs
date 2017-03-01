using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoubleShot : MonoBehaviour {
  public GameObject bullet;
  public Transform shootLocation;
  public SoundManager soundManager;
  public AudioClip shootSound;
  public PlayerMove location;

  // Use this for initialization
  void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown(KeyCode.E))
    {

      //create a new bullet object in a variable
      GameObject tempBullet = Instantiate(bullet, shootLocation.position, Quaternion.identity);

    }

    }
  }
