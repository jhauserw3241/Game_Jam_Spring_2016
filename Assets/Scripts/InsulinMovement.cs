using UnityEngine;
using System.Collections;

public class InsulinMovement : MonoBehaviour {
	public static float speed = 1.1f;
	private Rigidbody2D rb;
	private Rigidbody2D cluster1;
	private Rigidbody2D cluster2;
	
	// Use this for initialization
	void Start () {
	}
	
	void FixedUpdate() {
		rb = GetComponent<Rigidbody2D>();
		Vector2 p = rb.position;

		// Get clusters
		cluster1 = BackgroundScript.clusters[0];
		cluster2 = BackgroundScript.clusters[1];

		// Cluster positions
		Vector2 cp1 = cluster1.position;
		Vector2 cp2 = cluster2.position;

		// Distance from clusters
		float dist1 = Mathf.Sqrt(Mathf.Pow(p.x - cp1.x,2f) + Mathf.Pow(p.y - cp1.y,2f));
		float dist2 = Mathf.Sqrt(Mathf.Pow(p.x - cp2.x,2f) + Mathf.Pow(p.y - cp2.y,2f));

		// Get nearest cluster info
		Vector2 nearCluster = dist1 <= dist2 ? cp1 : cp2;

		// Move towards nearest cluster
		float xdif = nearCluster.x - p.x;
		float ydif = nearCluster.y - p.y;
		float peri = Mathf.Abs(xdif) + Mathf.Abs(ydif);
		rb.velocity = new Vector2 ((xdif/peri) * speed, (ydif/peri) * speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
