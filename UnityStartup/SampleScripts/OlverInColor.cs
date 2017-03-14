// Welcome to C#. This simple script illustrates the basics of OOP
// using specifies libraries of classes that should be used so you don't have to write everything yourself.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NOTE WELL:
// The class name must match the file name.  All game object component scripts are MonoBehaviours
// This line says that BallGetsColor inherits behavior for the class MonoBehavior.

// This says that OliverInColor is a subclass of MonoBehavior. 
// It is a public class so that it can be attached to Oliver in the Inspector.
// Note that if this code doesn't compile Unity3D will not let you attach it,
// nore will it allow the project to play if you've broken the code.
// Make the Console visible (its tab usually goes with the project tab) to see whether 
// Your code compiles.
public class OlverInColor : MonoBehaviour {

// Every MonoBehavior has a set of functions that exectued at various times. 
// The two essential ones are Start, which executes exactly once,
// and Update, which executes each time through the animation loop.

// Nothing specific to OliverInColor happens at Startup, so this is ok.
// Both of these methods are example of OVER-RIDING a method in the parent class, e.g 
// in MonoBehavior.

	// Use this for initialization
	void Start () {
	}

// You shoud be able to figure out what Update does. 
// Remember it is called EVERY time through the animation loop.
// Here is how to read the first 'if' statement:
// There is an object called Input that has a method called GetKeyDown that
// has a parameter that is a KeyCode. The Input class is called 'static' because
// you don't create instances of it, you just call it.  KeyCode is a static class too.
// It has data such as 'R' that is public that refers to the 'R' as well as the 'r' key.
// GetKeyDown returns 'true' if its parameter was the key pressed.

// GetComponent is a method that locates a component of a Unity object.
// GetComponent<Renderer> says 'find the component of type Renderer.
// Once you have that thing, look for its material, which has a color.
// Set that material to the Color red ha! another static class

// Your turn:  Add another if statement with another known color.
// Use the prompt to find out what colors exist, or start practicing looking things up 
// in the documentation.

	void Update()
	{
	if (Input.GetKeyDown(KeyCode.R))
		{
			GetComponent<Renderer> ().material.color = Color.red;
		}
	if (Input.GetKeyDown(KeyCode.G))
		{
			GetComponent<Renderer>().material.color = Color.green;
		}
	if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}