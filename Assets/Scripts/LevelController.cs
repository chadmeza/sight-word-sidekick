using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
	public Text wordText;

	private DataController dataController;
	private LevelData levelData;
	private WordData[] words;
	private int wordIndex;

	// Use this for initialization
	void Start () {
		dataController = FindObjectOfType<DataController> ();
		levelData = dataController.getCurrentLevelData ();
		words = levelData.words;

		wordIndex = 0;

		displayWord ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void displayWord() {
		wordText.text = words [wordIndex].word;
	}

	public void goToMenu() {
		SceneManager.LoadScene ("Menu");
	}

	public void goToPreviousWord() {
		if (wordIndex == 0) {
			wordIndex = words.Length - 1;
		} else {
			wordIndex--;
		}

		displayWord ();
	}

	public void goToNextWord() {
		if (wordIndex == words.Length - 1) {
			wordIndex = 0;
		} else {
			wordIndex++;
		}

		displayWord ();
	}

	public string getWordAudio() {
		string ext = ".mp3";
		return words [wordIndex].audio.Replace(ext, "");
	}
}
