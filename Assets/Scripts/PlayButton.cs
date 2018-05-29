using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class PlayButton : MonoBehaviour {
	private LevelController levelController;

	private AudioSource audio;

	void Start() {
		levelController = FindObjectOfType<LevelController> ();

		audio = gameObject.GetComponent(typeof(AudioSource)) as AudioSource;
	}

	void Update () {

	}

	public void HandleClick() {
		string currentWordAudio = levelController.getWordAudio ();

		audio.clip = Resources.Load<AudioClip> (currentWordAudio);
		audio.Play ();
	}
}