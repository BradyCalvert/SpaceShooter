using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour {

    public void Exit(int scene)
  {
    SceneManager.LoadScene("Credits");
  }
}
