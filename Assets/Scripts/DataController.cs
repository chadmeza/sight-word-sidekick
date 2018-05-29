using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour {
	public LevelData[] allLevelData;
	public int currentLevel;

	private string gameDataFileName = "data.json";

	public string filePath;
	public string result = "";

	void Awake() {
		// Path.Combine combines strings into a file path
		// Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
		filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
	}

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		StartCoroutine("LoadGameData");
		SceneManager.LoadScene ("Menu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setCurrentLevel(int level) {
		currentLevel = level;
	}

	public LevelData getCurrentLevelData() {
		return allLevelData [currentLevel];
	}

	IEnumerator LoadGameData() {
		if (filePath.Contains ("://")) {
			WWW www = new WWW (filePath);
			yield return www;
			result = www.text;
		} else {
			result = File.ReadAllText (filePath);
		}

		// Pass the json to JsonUtility, and tell it to create a GameData object from it
		GameData loadedData = JsonUtility.FromJson<GameData>(result);

		// Retrieve the allRoundData property of loadedData
		allLevelData = loadedData.allLevelData;
	}
}
