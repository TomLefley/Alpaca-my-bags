using UnityEngine;
using System.Collections;

public class NeckRotator : MonoBehaviour {

	private float prevRot = -90;

    private MovementControl movementControl;

    private PlayerInput input;

	// Use this for initialization
	void Start () {
	}

    void Awake() {
        movementControl = transform.root.GetComponentInChildren<MovementControl>();
        input = transform.root.GetComponentInChildren<PlayerInput>();

    }
	
	// Update is called once per frame
	void Update () {
		Vector2 newOrigin = transform.position;
		Vector2 relCursor = input.NeckLookat-newOrigin;
		float rot = 180 + Mathf.Atan2 (relCursor.y, relCursor.x)* Mathf.Rad2Deg;
		float totRot = rot-prevRot;
		if (!movementControl.facingRight) totRot = -totRot;
		prevRot = rot;
		transform.Rotate(0,0,totRot);

        
	}

	public void Flip() {
		Vector2 newOrigin = transform.position;
		Vector2 relCursor = input.NeckLookat-newOrigin;
		float rot = Mathf.Atan2 (relCursor.y, relCursor.x)* Mathf.Rad2Deg;
		float totRot = 180 + rot + prevRot;
		if (!movementControl.facingRight) totRot = -totRot;
		prevRot = rot;
		transform.Rotate(0,0,totRot);
	}
}
