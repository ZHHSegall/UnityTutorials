using UnityEngine;
using UnityEngine.UI; // This line is necessary to reference UI objects in the script

using UnityEngine.SceneManagement;

public class SceneSwitcher: MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Cycle(){
		int curSceneID = SceneManager.GetActiveScene().buildIndex;
		int numScenes = SceneManager.sceneCountInBuildSettings;

		//If we're at the last scene, cycles around to the first scene
		int nextSceneNum = (curSceneID + 1) % numScenes;

		SceneManager.LoadScene(nextSceneNum);
	}


}
