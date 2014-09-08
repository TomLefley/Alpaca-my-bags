using UnityEngine;
using System.Collections;

public class KeyBoardInput : PlayerInput {

    // Use this for initialization
    protected override void Start() {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update() {
        base.Update();
    }

    protected override void FindMovement() {
        Horizontal = Input.GetAxis("Horizontal");
    }

    protected override void FindJumping() {
        Jump = (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Jump") > 0);
    }

    protected override void FindNeckAngle() {
        NeckLookat = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    protected override void FindOptions() {
        Options = (Input.GetAxis("Cancel") > 0);
    }
}
