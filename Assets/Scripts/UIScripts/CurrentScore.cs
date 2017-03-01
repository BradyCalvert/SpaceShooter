using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentScore : MonoBehaviour {
  public EnemyAsteroid score;
  public UnityEngine.UI.Text text;

  // Use this for initialization
  void Start () {
    text = GetComponent<UnityEngine.UI.Text>();
  }
	
	// Update is called once per frame
	void OnGUI () {
    text.text = score.score.ToString();
		
	}
}
