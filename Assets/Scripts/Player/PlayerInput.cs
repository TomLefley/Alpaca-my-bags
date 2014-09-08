using UnityEngine;
using System.Collections;

public abstract class PlayerInput : MonoBehaviour {

    public float Horizontal { get; protected set; }

    public bool Jump { get; protected set; }

    public Vector2 NeckLookat { get; protected set; }

    public bool Options { get; protected set; }


	// Use this for initialization
	protected virtual void Start () {
        Horizontal = 0;

        Jump = false;

        NeckLookat = new Vector2();

        Options = false;
	}
	
	// Update is called once per frame
    protected virtual void Update() {
        FindMovement();
        FindJumping();
        FindNeckAngle();
        FindOptions();
	}

    protected abstract void FindMovement();

    protected abstract void FindJumping();

    protected abstract void FindNeckAngle();

    protected abstract void FindOptions();
}
