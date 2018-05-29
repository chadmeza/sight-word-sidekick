using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour {
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

		levelController.goToMenu ();
	}
}
