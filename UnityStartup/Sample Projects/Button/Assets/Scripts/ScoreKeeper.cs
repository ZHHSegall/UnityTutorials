using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections.Generic;


public class ScoreKeeper : MonoBehaviour {

	public Text pointsLabel;
	public Text hsLabel;
	int points;
	int highScore;
	// Use this for initialization
	void Start () {
		// File reading from "How to Write a File" Unity Forums
		// File reading test code
		string readFile = "Assets/TextFiles/Score.txt";
		points = 0;

		if (File.Exists (readFile)) {
			var scoreReader = File.OpenText (readFile);
			var line = scoreReader.ReadLine ();
			highScore = Int32.Parse (line); // Taken from MSDN https://msdn.microsoft.com/en-us/library/bb397679.aspx
			scoreReader.Close ();
		} else {
			Debug.Log ("Could not Open the file: " + readFile + " for reading.");
			return;
		}

		pointsLabel.text = "Points: " + points;
		hsLabel.text = "High Score: " + highScore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void  UpdateScore () {
		points++;
		pointsLabel.text = "Points: " + points;
		if(points > highScore){
			hsLabel.text = "High Score: " + points;
			const string WriteFile = "Assets/TextFiles/Score.txt";

			StreamWriter scoreWriter = File.CreateText (WriteFile);
			scoreWriter.WriteLine ("{0}", points);
			scoreWriter.Close ();
		}
	}


}
