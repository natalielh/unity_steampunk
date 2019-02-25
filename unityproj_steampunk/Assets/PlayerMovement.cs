using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    float horizontal_move = 0.0f;

    public float run_speed = 40f;

    bool jump = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        horizontal_move = Input.GetAxisRaw("Horizontal") * run_speed;

        if (Input.GetButtonDown("Jump")) {

            jump = true;

        }


	}

    void FixedUpdate() {

        controller.Move(horizontal_move * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

}
