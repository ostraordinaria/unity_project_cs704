using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

	// Use this for initialization
	int maxHealth = 100;
	int currentHealth = 0;

	void Start () {
		currentHealth = maxHealth;
	}

	public void Damage(int damage)
	{
		currentHealth -= damage;

		if (currentHealth <= 0) {
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
