using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_Brick : MonoBehaviour {
    public int hit=20;
    public int points = 1;
    private Vector3 startingPosition;
    public Vector2 startingVelocity = new Vector2(15, -20);
    //private Vector3 startingPosition;
    void Start () {
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {   
        hit = hit - 1;
        Debug.Log(hit);
        
        if (hit == 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().Brick_break(points);
        }
    }
}