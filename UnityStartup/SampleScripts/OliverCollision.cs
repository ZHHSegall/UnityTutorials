// These come for free.
using UnityEngine;
using System.Collections;


public class OliverCollision : MonoBehaviour {

	// Althought these are initially loaded, we don't use them here.
	// Use this for initialization
	//void Start () {
	//}
	// Update is called once per frame
	//void Update () {
	//	print ("Flying");
	// }
	void OnCollisionEnter2D(Collision2D collision)
	{
		print (gameObject.name + " " + collision.gameObject.name);
	}

	void OnCollisionStay2D(Collision2D collision)
	{
		print ("Stay.");
	}


	void OnCollisionExit2D(Collision2D collision)
	{
		Destroy (collision.gameObject);
		print("Exit.");
	}
}
