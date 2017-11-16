using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraXScript : MonoBehaviour {

	// Use this for initialization

	float mouseX = 0.0f;
	public float sensitivity = 5.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mouseX = Input.GetAxis ("Mouse X");

		Vector3 rotation = transform.localEulerAngles;
		rotation.y += mouseX * sensitivity;
		transform.localEulerAngles = rotation;
	}
}
