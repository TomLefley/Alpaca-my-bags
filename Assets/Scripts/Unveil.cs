using UnityEngine;
using System.Collections;

public class Unveil : MonoBehaviour {

	bool unveiled = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (!(col.collider.CompareTag("Player")||col.collider.CompareTag("Head")) || unveiled || GameObject.Find("game state").GetComponent<GameState>().state == GameState.State.end) return;
		GameObject o = GameObject.Find(name+"_ui");
		o.BroadcastMessage("position");
		o.GetComponent<SpriteRenderer>().enabled = true;
		unveiled = true;
	}
}
