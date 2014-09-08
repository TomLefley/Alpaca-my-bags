using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	Timer timer;

	public enum State {playing, end};

	public State state;

	// Use this for initialization
	void Start () {
		timer = gameObject.GetComponentInChildren<Timer>();
	}

	void Awake() {
		state = State.playing;
	}
	
	// Update is called once per frame
	void Update () {
		if (state == State.end && Input.GetKeyUp(KeyCode.Return)) {
			Application.LoadLevel ("game"); 
		}

		if (timer.time == -1) {
			state = State.end;
			GameObject.Find("collected").GetComponent<Animator>().SetTrigger("End");
			//GameObject.Find ("suitcase").GetComponent<Animator>().SetTrigger("End");
		}
	}
}
