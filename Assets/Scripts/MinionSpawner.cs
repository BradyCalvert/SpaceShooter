using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSpawner : MonoBehaviour {
  public float spawnTimeMin;
  public float spawnTimeMax;
  public Boundry spawningLocation;
  public GameObject enemy;
	// Use this for initialization
	void Start () {
    StartCoroutine("Minion");
		
	}
	
	// Update is called once per frame
	IEnumerator Minion () {
    Vector3 newPos = transform.position;
    newPos.x = Random.Range(spawningLocation.horizontalMin, spawningLocation.horizontalMax);
    newPos.y = Random.Range(spawningLocation.verticalMin, spawningLocation.verticleMax);
    newPos.z = Random.Range(0f, 5f);
    Vector3 newScale = transform.localScale;
    newScale.x = Random.Range(1.0f, 3.5f);
    newScale.y = newScale.x;
    newScale.z = newScale.x;
    Instantiate(enemy, newPos,Quaternion.identity).transform.localScale=newScale;
    yield return new WaitForSeconds(Random.Range(spawnTimeMin,spawnTimeMax));

		
	}
}
