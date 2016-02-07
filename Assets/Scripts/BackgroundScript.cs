using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundScript : MonoBehaviour {
	public static List<Rigidbody2D> clusters = new List<Rigidbody2D>();

	// Use this for initialization
	void Start () {
		// Set gravity to fall right
		Physics2D.gravity = new Vector2(10f, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
