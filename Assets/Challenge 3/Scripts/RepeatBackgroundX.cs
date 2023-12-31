﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    private bool gameOver = false;
    private void Start()
    {
        gameOver = GameObject.Find("Player").GetComponent<PlayerControllerX>().gameOver;
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth && !gameOver)
        {
            transform.position = startPos;
        }
    }

 
}


