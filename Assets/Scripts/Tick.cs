using UnityEngine;
using System.Collections;

public class Tick : MonoBehaviour {

	static int collected = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void tick() {
		//gameObject.GetComponent<SpriteRenderer>().color = Color.white;
		GetComponent<Animator>().SetTrigger("Collect");
	}

	void position() {
		transform.Translate(new Vector2(collected*35,0));
		collected++;
	}
}
