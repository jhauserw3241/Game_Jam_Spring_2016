using UnityEngine;
using System.Collections;

public class RotateInCircle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Get the current objects tranform properties
		Transform objTransProps = this.gameObject.transform;

		// Rotate object
		objTransProps.Rotate(Vector3.forward, 2f, Space.Self);
	}
}
