using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

	// Use this for initialization
	int DamageDone = 50;

	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape)) {
			Cursor.lockState = CursorLockMode.None;
		}
		
		if (Input.GetMouseButtonDown (0)) {
			Ray mouseRay = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
			RaycastHit hitInfo;

			if (Physics.Raycast (mouseRay, out hitInfo)) {
				//Debug.Log (hitInfo.transform.name);
				HealthScript enemyHealth = hitInfo.transform.GetComponent<HealthScript> ();
				if (enemyHealth != null) {
					enemyHealth.Damage (DamageDone);
				}
			}
		}
	}
}

