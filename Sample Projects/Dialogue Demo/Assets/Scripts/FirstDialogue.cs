using UnityEngine;
using UnityEngine.UI; // This line is necessary to reference UI objects in the script
using System.Collections;

public class FirstDialogue : MonoBehaviour {

	public Text Catherine;
	public Text Oliver;
	public InputField user;
	public  Text Input;
	
	private int clicks;
	bool wait = false;
	string name;

	// Use this for initialization
	void Start () {
		clicks = 0;
		Oliver.text = "";
		Catherine.text = "";
		user.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnClick(){
		if(!wait)
			clicks++;

		switch(clicks){
			case 1: 
				Oliver.text = "Hi Catherine.";
				Catherine.text = "";
				break;
			case 2: 
				Oliver.text = "";
				Catherine.text = "Hi Oliver!";
				break;
			case 3:
				Oliver.text = "Who's your friend?";
				Catherine.text = "";
				user.interactable = true;
				wait = true;
				break;
			case 4:
				Oliver.text = "Hi " + name;
				break;
			default:
				Oliver.text = "";
				Catherine.text = "";
				break;
		}
	}

	public void getName(){
		name = user.text;
		wait = false;
	}

}
