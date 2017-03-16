using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int hit = 1;
    public int points = 1;
    // Use this for initialization
    void Start () {
        //startingPosition = transform.position;
        //GetComponent<Rigidbody2D>().velocity = startingVelocity;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        hit = hit- 1;
        Debug.Log(hit);
        GetComponent<SpriteRenderer>().color = new Color(1,1,1,hit*.2f);
        if (hit == 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().Brick_break(points);
        }
    }
}