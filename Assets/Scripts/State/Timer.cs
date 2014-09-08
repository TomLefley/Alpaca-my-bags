using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float time = 150;
	int prevSec = 5;

	int minutes;
	int seconds;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {
		time = Mathf.Max (time-Time.deltaTime, -1);
		if (time<0) {
			GetComponent<GUIText>().enabled = false;
		}
		
		minutes = Mathf.FloorToInt(time/60);
		seconds = Mathf.FloorToInt(time%60);

		if (minutes == 0 && seconds < 6) {
			guiText.fontSize = (seconds == prevSec) ? guiText.fontSize+1 : 72;
			prevSec = seconds;
		} else if (seconds == 0) {
			guiText.fontSize++;
		} else {
			guiText.fontSize = 72;

		}

		if (seconds < 10) {
			guiText.text = minutes.ToString()+":0"+seconds.ToString ();
		}
		else guiText.text = minutes.ToString()+":"+seconds.ToString ();
	}
}
