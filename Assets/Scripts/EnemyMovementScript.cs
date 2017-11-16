using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour {

	// Use this for initialization
	Transform player;
	CharacterController controller;
	float movementSpeed = 5.0f;
	float gravity = 2.0f;
	float yVelocity = 0.0f;

	void Start () {
		GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
		player = playerObj.transform;

		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = player.position - transform.position;
		direction.Normalize ();

		Vector3 velocity = direction * movementSpeed;

		//gravitasi supaya model zombie ga melayang
		if (!controller.isGrounded) {
			yVelocity -= gravity;
		}

		velocity.y = yVelocity;
		//enemy menghadap player
		direction.y = 0; //tambah direction supaya ga aneh pergerakannya.
		transform.rotation = Quaternion.LookRotation (direction);
		controller.Move (velocity * Time.deltaTime);
	}
}
