using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public const float speed = 5f;
	private float movex = 0f;
	private float movey = 0f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		// Set gravity to fall right
		Physics2D.gravity = new Vector2 (10f, 0);
	}

	void FixedUpdate() {
		// Get insulin rigidbody
		rb = GetComponent<Rigidbody2D>();

		// Horizontal movement
		movex = Input.GetAxis ("Horizontal");

		// Vertical movement
		movey = Input.GetAxis ("Vertical");

		// Alter Insulin movement
		rb.velocity = new Vector2 (movex * speed, movey * speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
