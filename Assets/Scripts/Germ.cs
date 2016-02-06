using UnityEngine;
using System.Collections;

public class Germ : MonoBehaviour
{
	private Rigidbody2D myRigidbody;
	bool hasInsulin = false;
	double speed = 2.0;

	// Use this for initialization
	void Start()
	{
		myRigidbody = GetComponent<Rigidbody2D>();
	}

	// Kill the attached insulin
	void KillInsulin()
	{
		if (hasInsulin) {
			speed = speed * 0.6;
		}
	}
	
	// Update is called once per frame
	void Update()
	{
		HandleMovement();
	}

	// Handle the movement to the left of the screen
	private void HandleMovement()
	{
		myRigidbody.velocity = Vector2.left; // x = -1, y = 0
	}
}
