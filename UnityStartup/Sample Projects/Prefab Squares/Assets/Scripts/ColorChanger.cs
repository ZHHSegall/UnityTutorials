using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour {
	public GameObject ob;
	// Use this for initialization
	void Start () {
		Color c = Color.white;
		c.r = ob.transform.position.x;
		ob.SpriteRenderer.color = c;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
