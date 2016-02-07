using UnityEngine;
using System.Collections;

public class RotateFace : MonoBehaviour {
	int rotateCount = 3;
	float deltaAngle = 1f;
	int modVal = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Get the current objects tranform properties
		Transform objTransProps = this.gameObject.transform;

		// Determine the current position of the object
		float zDeg = objTransProps.eulerAngles.z;
		Debug.Log (zDeg.ToString ());

		if (rotateCount > 30 || rotateCount < -30)
		{
			modVal *= -1;
		}
		rotateCount += modVal;

		// Rotate object
		//objTransProps.Rotate(Vector3.forward, (zDeg + (rotateAngle * modVal)), Space.Self);
		objTransProps.Rotate(new Vector3(0, 0, modVal * deltaAngle), Space.Self);
	}
}
