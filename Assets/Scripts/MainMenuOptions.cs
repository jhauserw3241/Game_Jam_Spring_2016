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
	}

	// Handle game options
	private void OnGUI()
	{
		// Transition to logo scene
		if (GUI.Button (new Rect ((Screen.width / 2) - 100, Screen.height / 2, 200, 100), "Start"))
		{
			Application.LoadLevel("LogoScene");
		}

		// Exit game
		if (GUI.Button (new Rect ((Screen.width / 2) - 100, (Screen.height / 2) + 150, 200, 100), "Quit"))
		{
			Application.Quit();
		}
	}
}
