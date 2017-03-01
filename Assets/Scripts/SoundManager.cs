using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource soundSFX;
	public AudioSource soundBackGround;

	// Use this for initialization
	void Start () {

		//play background music
		
	}
	
	public void PlaySFX(AudioClip soundToPlay)
	{
		//Assign soundFX audiosource to the clip
		soundSFX.clip=soundToPlay;

		//play the clip
		soundSFX.Play();



	}
}

