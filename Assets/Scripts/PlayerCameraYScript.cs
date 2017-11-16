using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraYScript : MonoBehaviour {

	// Use this for initialization
	float mouseY = 0.0f;
	public float sensitivity = 3.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mouseY = Input.GetAxis ("Mouse Y") * -1;

		Vector3 rotation = transform.localEulerAngles;
		rotation.x += mouseY * sensitivity;
		transform.localEulerAngles = rotation;
	}
}
