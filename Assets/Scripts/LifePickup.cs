using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickup : MonoBehaviour {

  public float timer=2f;
  PlayerHealth playerHealth;
  public GameObject lifePickup;

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("pickup"))
    {
      playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
      playerHealth.numLives++;
      //Instantiate(other.gameObject, new Vector3(Random.Range(-5f, 19f), Random.Range(-3f, 5f), -5.61f), Quaternion.identity);
      //Destroy(other.gameObject);
    }
    Destroy(other.gameObject);
  }
}
