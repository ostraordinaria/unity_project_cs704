using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour {

	// Use this for initialization
	public Texture2D crosshair;


	void OnGUI(){
		float x = (Screen.width - crosshair.width) / 2;
		float y = (Screen.height - crosshair.height) / 2;
		GUI.DrawTexture (new Rect (x, y, crosshair.width, crosshair.height), crosshair);
	}
}
