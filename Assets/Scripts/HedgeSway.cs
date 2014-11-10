using UnityEngine;
using System.Collections;

public class HedgeSway : MonoBehaviour {

	private int timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (timer == 0) timer = 200;
		if (timer == 200) transform.Translate(new Vector2(1,0));
		if (timer == 150) transform.Translate(new Vector2(-1,0));
		if (timer == 100) transform.Translate(new Vector2(-1,0));
		if (timer == 50) transform.Translate(new Vector2(1,0));
		timer--;
	}
}
