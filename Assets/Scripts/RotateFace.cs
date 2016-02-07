using UnityEngine;
using System.Collections;

public class RotateFace : MonoBehaviour {
	float rotateAngle = 2f;
	float modVal = 1f;
	float degCount = 0f;

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

		//if( (zDeg >= 30f) || (zDeg <= -30f))
		//{
		//	modVal *= -1f;
		//}

		if( (degCount >= 30f) || (degCount <= -30f))
		{
			modVal *= -1f;
		}
		degCount = degCount + (rotateAngle * modVal);

		//Debug.Log ((zDeg + (rotateAngle * modVal)).ToString ());
		//Debug.Log (modVal.ToString ());

		// Rotate object
		//objTransProps.Rotate(Vector3.forward, (zDeg + (rotateAngle * modVal)), Space.Self);
		objTransProps.Rotate(Vector3.forward, degCount, Space.Self);
	}
}
