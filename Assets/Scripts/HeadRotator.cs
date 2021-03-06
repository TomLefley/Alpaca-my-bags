﻿using UnityEngine;
using System.Collections;

public class HeadRotator : MonoBehaviour {

	private float prevRot = -90;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 cursorPos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 newOrigin = transform.position;
		Vector2 relCursor = cursorPos-newOrigin;
		float rot = 180 + Mathf.Atan2 (relCursor.y, relCursor.x)* Mathf.Rad2Deg;
		float totRot = rot-prevRot;
		if (!transform.parent.gameObject.GetComponent<HeroControl>().facingRight) totRot = -totRot;
		prevRot = rot;
		transform.Rotate(0,0,totRot);
	}

	public void Flip() {
		Vector3 cursorPos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 newOrigin = transform.position;
		Vector2 relCursor = cursorPos-newOrigin;
		float rot = Mathf.Atan2 (relCursor.y, relCursor.x)* Mathf.Rad2Deg;
		float totRot = 180 + rot+prevRot;
		if (!transform.parent.gameObject.GetComponent<HeroControl>().facingRight) totRot = -totRot;
		prevRot = rot;
		transform.Rotate(0,0,totRot);
	}
}
