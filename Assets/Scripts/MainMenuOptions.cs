using UnityEngine;
using System.Collections;

public class MainMenuOptions : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Determine if the user wants to start the game
		if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 2, 80, 20), "Start"))
		{
			Application.LoadLevel("LogoScene");
		}

		// Determine if the user wants to quit the game
		if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 2 + 100, 80, 20), "Quit"))
		{
			Application.Quit();
		}
	}
}
