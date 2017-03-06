// Much of this should look familiar
// However two variables (data items) have been introduced:
// startColor is PRIVATE, which means it isn't visible outside this class.
// oliverColor is PUBLIC, which means you can see it and manipulate it in the Inspector.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlverShares : MonoBehaviour {

	private Color startColor = Color.white;
	public Color oliverColor;

// Note that we are printing information to the Console, a good way to debug code.
// What color does Oliver start off with?
	// Use this for initialization
	void Start () {
		Debug.Log (oliverColor + " " + startColor);
		GetComponent<Renderer>().material.color = startColor;
	}

// When the space bar is pressed Oliver's color changes. 
// You can change the color in the Inspector using the Color Picker.
// Click on the oliverColor slot in the scripts Inspector view.
	void Update()
	{
	if (Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Renderer> ().material.color = oliverColor;
			Debug.Log (oliverColor);
		}

// This is an extra:  it shows how to specify a more complex color.  Check out the documentation
// for more information on what the parameters are to the Color constructor.
// This code is saying that the material color will be a new instance of a color. What color is it?
	if (Input.GetKeyDown(KeyCode.E))
		{
			GetComponent<Renderer> ().material.color = new Color (1, 0, 0, 1);
		}


	}
}