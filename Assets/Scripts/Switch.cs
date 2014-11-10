using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	int switchCD = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switchCD = Mathf.Max (0, switchCD-1);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.CompareTag("Head") && switchCD == 0) {
			int intensity = (int)transform.parent.GetComponentInChildren<Light>().intensity;
			intensity ^= 8;
			transform.parent.GetComponentInChildren<Light>().intensity = intensity;
			switchCD = 100;
		}
	}
}
