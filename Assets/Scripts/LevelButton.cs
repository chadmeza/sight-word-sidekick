using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour {
	private DataController dataController;
	private MenuController menuController;

	private AudioSource audio;

	void Start() {
		dataController = FindObjectOfType<DataController> ();
		menuController = FindObjectOfType<MenuController> ();

		audio = gameObject.GetComponent(typeof(AudioSource)) as AudioSource;
	}
	
	void Update () {
		
	}

	public void HandleClick() {
		if (audio != null) {
			audio.Play ();
		}

		switch (gameObject.name) {
			case "Level 1":
				dataController.setCurrentLevel (0);
				break;
			case "Level 2":
				dataController.setCurrentLevel (1);
				break;
			case "Level 3":
				dataController.setCurrentLevel (2);
				break;
			case "Level 4":
				dataController.setCurrentLevel (3);
				break;
			case "Level 5":
				dataController.setCurrentLevel (4);
				break;
			case "Level 6":
				dataController.setCurrentLevel (5);
				break;
			case "Level 7":
				dataController.setCurrentLevel (6);
				break;
			case "Level 8":
				dataController.setCurrentLevel (7);
				break;
			case "Level 9":
				dataController.setCurrentLevel (8);
				break;
			case "Level 10":
				dataController.setCurrentLevel (9);
				break;
			default:
				dataController.setCurrentLevel (0);
				break;
		}

		menuController.StartGame ();
	}
}
