using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAsteroid : MonoBehaviour {

  public float movementSpeed;
  public GameObject explosion;
  public AudioClip explosionSound;
  public AudioClip shieldExplosion;
  public AudioClip playerDamage;
  public Boundry spawningLocation;
  public PlayerHealth playerHealth;
  public SoundManager soundManager;
  public int score=0;
  public float time;
  public int highScore;
  string highScoreKey = "highScore";
  PlayerShield shield;
  private int sceneBuildIndex;

  // Use this for initialization
  void Start () {
    int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    //Find the SoundManager component in the object heiarchy
    soundManager =GameObject.Find("SoundManager").GetComponent<SoundManager>();
	
    //Find the object with the Player tag in the Heiarchy
		playerHealth=GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
			
	}
	
	// Update is called once per frame
	void Update () {
    {
      time++;
      if (time >= 2000)
      { ChangeScene(); }
    }

    //Move the object in the back direction, accounting for movementSpeed
    transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);

    //Is behind player?
		if (transform.position.z < playerHealth.gameObject.transform.position.z) 
		{
      soundManager.PlaySFX(explosionSound);
			ResetEnemy ();
		}

      //Call the ResetEnemy() method
		
	}

	void ResetEnemy()
	{
		//Debug.Log ("Testing");
		//Create a new vector and store current position in it
		Vector3 newPos= transform.position;
		newPos.x = Random.Range (spawningLocation.horizontalMin, spawningLocation.horizontalMax);
		newPos.y = Random.Range (spawningLocation.verticalMin, spawningLocation.verticleMax);
		newPos.z = 21;
		movementSpeed = Random.Range (1.0f, 5.0f);
    Vector3 newScale = transform.localScale;
    newScale.x = Random.Range(1.0f, 5.0f);
    newScale.y = newScale.x;
    newScale.z = newScale.x;

    transform.localScale = newScale; 
		transform.position = newPos;

	}

  void OnTriggerEnter(Collider other)
  {
    //Did collide with player?
    if (other.gameObject.CompareTag("Player"))
    {
      Debug.Log("Hit Player");

      if (explosion != null)
      {
        GameObject tempExplo = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(tempExplo, 1.0f);
        soundManager.PlaySFX(playerDamage);
      }
      ResetEnemy();
    }
    else if (other.gameObject.CompareTag("Shield"))
    {
      GetComponent<PlayerShield>().shieldActive = false;
      Debug.Log("Hit Shield");

      if (explosion != null)
      {
        GameObject tempExplo = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(tempExplo, 1.0f);
        soundManager.PlaySFX(shieldExplosion);

      }
      ResetEnemy();
    }
    else if (other.gameObject.CompareTag("Bullet"))
    {
      score++;
      Debug.Log(score);
      PlayerPrefs.SetInt("Score1", score);
      PlayerPrefs.SetString("PlayerName", "Player 1");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score2", score-1);
      PlayerPrefs.SetString("PlayerName", "Player 2");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score3", score-2);
      PlayerPrefs.SetString("PlayerName", "Player 3");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score4", score-1);
      PlayerPrefs.SetString("PlayerName", "Player 4");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score5", score-3);
      PlayerPrefs.SetString("PlayerName", "Player 5");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score6", score-1);
      PlayerPrefs.SetString("PlayerName", "Player 6");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score7", score-4);
      PlayerPrefs.SetString("PlayerName", "Player 7");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score8", score-2);
      PlayerPrefs.SetString("PlayerName", "Player 8");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score9", score-3);
      PlayerPrefs.SetString("PlayerName", "Player 9");
      PlayerPrefs.Save();
      PlayerPrefs.SetInt("Score10", score-1);
      PlayerPrefs.SetString("PlayerName", "Player 10");
      PlayerPrefs.Save();
      ResetEnemy();
    }
  }

    void ChangeScene()
  {

      SceneManager.LoadScene(sceneBuildIndex+1);
    }
  
  /*//Set score in playerprefs
if (PlayerPrefs.HasKey ("Score1") == true) {

int tempScore = PlayerPrefs.GetInt("Score1");
} 

if (100 > tempScore) {

  PlayerPrefs.SetInt ("Score1", 100);

}





if (PlayerPrefs.HasKey ("Score1") == false) 
{
PlayerPrefs.SetInt ("Score1", 100);
}

//Load the appropriate scene
SceneManager.LoadScene(sceneName);
}*/
}


