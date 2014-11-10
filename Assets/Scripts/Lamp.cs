using UnityEngine;
using System.Collections;

public class Lamp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.collider.CompareTag("Player") || col.collider.CompareTag ("Head")) {
			foreach (Light l in transform.GetComponentsInChildren<Light>()) {
				l.intensity = 0;
			}
		}
	}
}
