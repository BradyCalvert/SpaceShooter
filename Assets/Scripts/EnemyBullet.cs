using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
  public float movementSpeed;
  public PlayerHealth playerHealth;
  // Use this for initialization
  void Start () {
    playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();

  }
	
	// Update is called once per frame
	void Update () {
    transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
    if (transform.position.z < playerHealth.gameObject.transform.position.z)
    {
      Destroy(gameObject);
    }

  }
}
