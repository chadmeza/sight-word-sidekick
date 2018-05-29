using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour {
	private LevelController levelController;

	private AudioSource audio;

	void Start() {
		levelController = FindObjectOfType<LevelController> ();

		audio = gameObject.GetComponent(typeof(AudioSource)) as AudioSource;
	}

	void Update () {

	}

	public void HandleClick() {
		if (audio != null) {
			audio.Play ();
		}

		levelController.goToNextWord ();
	}
}
