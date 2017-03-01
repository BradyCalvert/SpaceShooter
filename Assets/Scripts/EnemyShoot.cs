using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
  public GameObject bullet;
  public EnemyAsteroid enemy;
  public float shootMin;
  public float shootMax;

	// Use this for initialization
	void Start () {
    //StartCoroutine("BulletSpawn");
    InvokeRepeating("BulletSpawn", shootMin, shootMax);
		
	}
	
	// Update is called once per frame
	void BulletSpawn () {
    Instantiate(bullet, gameObject.transform.position,Quaternion.identity);
     // yield return new WaitForSeconds(Random.Range(shootMin, shootMax));
		
	}
}
