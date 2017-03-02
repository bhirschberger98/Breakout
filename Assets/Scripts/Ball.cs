using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector2 startingVelocity = new Vector2(15, -20);

	void Start () {
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
	}
	
	void Update () {
        if (transform.position.y < 3.5f) ;
	}
    void GetOut(){
        Debug.Log("you are out");
    } 
}
