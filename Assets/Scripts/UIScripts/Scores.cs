using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {

  public UnityEngine.UI.Text text;
  public UnityEngine.UI.Text text2;
  public UnityEngine.UI.Text text3;
  public UnityEngine.UI.Text text4;
  public UnityEngine.UI.Text text5;
  public UnityEngine.UI.Text text6;
  public UnityEngine.UI.Text text7;
  public UnityEngine.UI.Text text8;
  public UnityEngine.UI.Text text9;
  public UnityEngine.UI.Text text10;

  // Use this for initialization
  void Start () {
    text = GetComponent<UnityEngine.UI.Text>();
    text2 = GetComponent<UnityEngine.UI.Text>();
    text3 = GetComponent<UnityEngine.UI.Text>();
    text4 = GetComponent<UnityEngine.UI.Text>();
    text5 = GetComponent<UnityEngine.UI.Text>();
    text6 = GetComponent<UnityEngine.UI.Text>();
    text7 = GetComponent<UnityEngine.UI.Text>();
    text8 = GetComponent<UnityEngine.UI.Text>();
    text9 = GetComponent<UnityEngine.UI.Text>();
    text10 = GetComponent<UnityEngine.UI.Text>();
  }

  private void OnGUI()
  {
    text.text = PlayerPrefs.GetString("PlayerName")+ ":" + PlayerPrefs.GetInt("Score1");
    text2.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score2");
    text3.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score3");
    text4.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score4");
    text5.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score5");
    text6.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score6");
    text7.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score7");
    text8.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score8");
    text9.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score9");
    text10.text = PlayerPrefs.GetString("PlayerName") + ":" + PlayerPrefs.GetInt("Score10");
  }
}