using UnityEngine;
using System.Collections;

public class Platformer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		collider2D.isTrigger = false;
		bool falling = transform.parent.rigidbody2D.velocity.y < -0;
		if (Input.GetAxis("Vertical") < 0) {
			collider2D.isTrigger = true;
		}
		Physics2D.IgnoreLayerCollision(14, 13, !falling);
	}

}
