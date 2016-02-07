using UnityEngine;
using System.Collections;

public class Germ : MonoBehaviour
{
	private Rigidbody2D myRigidbody;
	bool hasInsulin = false;
	float speed = 2f;

	// Use this for initialization
	void Start()
	{
		myRigidbody = GetComponent<Rigidbody2D>();
	}

	// Kill the attached insulin
	void KillInsulin()
	{
		if (hasInsulin) {
			speed = speed * (float)0.6;
		}
	}
	
	// Update is called once per frame
	void Update()
	{
		//float horizontal = Input.GetAxis ("Horizontal");
		HandleMovement();
	}

	// Handle the movement to the left of the screen
	private void HandleMovement()
	{
		myRigidbody.velocity = new Vector2(-speed, 0); // x = -1, y = 0
	}
}
