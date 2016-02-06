using UnityEngine;
using System.Collections;

public class Player1 : PlayerMovement {
	
	// Use this for initialization
	new void Start() {
		base.Start();
	}
	
	void FixedUpdate() {
		// Horizontal movement
		movex = Input.GetAxis ("Horizontal1");
		
		// Vertical movement
		movey = Input.GetAxis ("Vertical1");
		
		// Alter player movement
		move(movex, movey);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

