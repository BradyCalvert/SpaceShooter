using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour {

    public void Return(int scene)
  {
    SceneManager.LoadScene("MainMenu");
  }
}
