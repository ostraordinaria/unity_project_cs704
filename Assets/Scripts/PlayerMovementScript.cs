using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

	// Use this for initialization
	CharacterController controller;
	float movementSpeed = 5.0f;
	float jumpSpeed = 20.0f;
	float gravity = 1.0f;
	float yVelocity = 0.0f;

	void Start ()
	{
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 direction = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		Vector3 velocity = direction * movementSpeed;

		if (controller.isGrounded && Input.GetKeyDown (KeyCode.Space)) {
			yVelocity = jumpSpeed;
		} else {
			yVelocity -= gravity;
		}

		velocity.y = yVelocity;

		controller.Move (velocity * Time.deltaTime);
	}
}