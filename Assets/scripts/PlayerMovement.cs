﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
       if (Input.GetKeyDown(KeyCode.Space))
       {
           jump = true;
       }
    }
    void FixedUpdate()
    {
        //move character
        controller.Move(horizontalMove*Time.fixedDeltaTime,jump);
        jump = false;
    }
    

}
