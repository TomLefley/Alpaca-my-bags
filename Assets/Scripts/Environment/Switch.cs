using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	int switchCd = 0;
    bool on = false;

    public float intensity;

    public Light pointLight;
    public SpriteRenderer shade;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switchCd = Mathf.Max (0, switchCd-1);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.CompareTag("Head") && switchCd == 0) {
            if (on) {
                pointLight.intensity = 0;
                shade.color = new Color(200, 200, 200);
            } else {
                pointLight.intensity = intensity;
                shade.color = new Color(255, 255, 255);
            }
            on = !on;
			switchCd = 100;
		}
	}
}
