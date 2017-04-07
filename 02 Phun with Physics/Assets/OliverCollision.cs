// These come for free.
using UnityEngine;
using System.Collections;

// In order to deal with a collision, the event handler (that is part of the game engine), call the
// methods below when the colliders interact. 
public class OliverCollision : MonoBehaviour {

	// Althought these are initially loaded, we don't use them here.
	// Use this for initialization
	//void Start () {
	//}
	// Update is called once per frame
	//void Update () {
	//	print ("Flying");
	// }
	// Check out the Console planel to see who is the game object and what is the name of the collision game object

	//  This method is called by the event handler when Oliver crosses the ball's line.
	void OnCollisionEnter2D(Collision2D collision)
	{
		print (gameObject.name + " " + collision.gameObject.name);
	}

	// This method is called by the event handler while the objects remain in collision.
	void OnCollisionStay2D(Collision2D collision)
	{
		print ("Stay.");
	}

	// This method is called by the event handler when Oliver is no longer touching the ball.
	void OnCollisionExit2D(Collision2D collision)
	{
		Destroy (collision.gameObject);
		print("Exit.");
	}
}
