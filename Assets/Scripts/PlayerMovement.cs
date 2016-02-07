using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public static float speed = 1f;
	protected float movex = 0f;
	protected float movey = 0f;
	protected Rigidbody2D rb;

	// Use this for initialization
	public void Start () {
		// Alter player movement
		rb = GetComponent<Rigidbody2D>();

		// Add cluster to public cluster list
		BackgroundScript.clusters.Add(rb);
	}
	
	public void move(float x, float y) {
		//Debug.Log (rb);
		rb.velocity = new Vector2(x * speed, y * speed);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
