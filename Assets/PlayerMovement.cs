using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private float movex = 0f;
	private float movey = 0f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate() {
		rb = GetComponent<Rigidbody2D>();
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		Debug.Log("x: " + movex + " y: " + movey);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
