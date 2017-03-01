using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShotPickup : MonoBehaviour {

  public GameObject doubleShot;
  public GameObject bullet;
  public Transform shootLocation;
  public Transform shootLocation2;
  public SoundManager soundManager;
  public AudioClip shootSound;
  bool isPickup;
  //[SerializeField]
  private int amount=10;

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("DoubleShot"))
    {
      isPickup = true;
    }
  }
    void Update()
      {
        if (isPickup == true && Input.GetKeyDown(KeyCode.E) && amount>0)
        {
          GameObject tempBullet = Instantiate(bullet, shootLocation.position, Quaternion.identity);
          GameObject tempBullet2 = Instantiate(bullet, shootLocation2.position, Quaternion.identity);
          //Debug.Log(amount);
          amount--;
        }
      }
  }
