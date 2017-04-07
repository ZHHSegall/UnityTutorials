// This is where the power of classes comes in.
// One instance of a class can reference another.
// The key is inserting the Game Object 'Oliver' into the value of the 'MyFriend' public
// variable in the 'TBall' Ball Gets Color script.
// Once the connection is made the ball can change its color to Oliver's color.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The class name must match the file name.  All scripts are MonoBehaviours
// This line says that BallGetsColor inherits behavior for the class MonoBehavior.
public class BallGetsColor : MonoBehaviour {

	public GameObject myFriend;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.color = new Color (1, 1, 1, 1);
		Debug.Log ("The tennis ball thinks" + " " + myFriend.name + " is its friend");
		Debug.Log ("My friend's color is " + myFriend.GetComponent<Renderer> ().material.color);
	}

// Even though GetComponent is expensive, it is being invoked here.  Why? 
// Hint: Update is called repeatedly. Start only gets called at that start.
	void Update()
	{
	if (Input.GetKeyDown(KeyCode.C))
		{
			GetComponent<Renderer> ().material.color = myFriend.GetComponent<Renderer> ().material.color;
		}
	}
}