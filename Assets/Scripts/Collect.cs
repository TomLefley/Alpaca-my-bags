using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (!col.gameObject.CompareTag("Prop") || GameObject.Find("game state").GetComponent<GameState>().state == GameState.State.end) return;
		GameObject.Find(col.gameObject.name+"_ui").BroadcastMessage("tick");
		GameObject.Destroy(col.gameObject);
	}
}
