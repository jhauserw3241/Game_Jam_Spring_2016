using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {
	float initTime;

	// Use this for initialization
	void Start ()
	{
		initTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Transition to logo scene
		if((Time.time - initTime) > (float)5) {
			Application.LoadLevel ("Level1");
		}
	}
}
