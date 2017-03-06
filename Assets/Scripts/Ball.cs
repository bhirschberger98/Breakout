﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector2 startingVelocity = new Vector2(15, -20);
    public GameObject gameOver;
    private Vector3 startingPosition;
    int lives = 3;
        void Start () {
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
	}
	
	void Update () {
        if (transform.position.y <-3.5f){
            GetOut();
        }
        if (Input.GetButtonDown("jump"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2();
        }
	}
    void GetOut(){
        Debug.Log("you are out");
        lives = lives - 1;
        transform.position = startingPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector2();

        if (lives == 0)
        {
            DoGameOver();
        }
    }
    void DoGameOver()
    {
        gameOver.SetActive(true);
    } 
}
