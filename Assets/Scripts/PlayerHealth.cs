using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

  public float numLives = 3;
  public PlayerShield playerShield;
  public int score;
  public int highScore;
  public float time;
  string highScoreKey = "highScore";


  // Use this for initialization
  void Start() {
    float time = Time.time;

    //Get the playerShield component and store it in a variable
    playerShield = GetComponent<PlayerShield>();
    PlayerPrefs.GetInt(highScoreKey, 0);

  }


  void OnTriggerEnter(Collider other)
  {
    //Is shield active?
    if (playerShield.shieldActive == false)
    {
      if (other.CompareTag("Enemy") || other.CompareTag("EnemyBullet"))
      {
        TakeLife();
      }
    }





  }

  //Call TakeLife() method.




  public void TakeLife()
  {
    //Reduce lives by 1
    numLives--;

    //Out of lives?
    if (numLives <= 0)
    {
      Debug.Log("Just died");
      ChangeScene("GameOver");
    }





    //Call the ChangeScenes() method to go to the GameOver scene
  }
  void ChangeScene(string sceneName)
  {

    SceneManager.LoadScene("GameOver");
  }

}
  

