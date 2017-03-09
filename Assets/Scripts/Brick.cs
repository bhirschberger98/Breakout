using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int hit = 1;
    // Use this for initialization
    void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        hit = hit- 1;
        Debug.Log(hit);
        if (hit == 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().Brick_break();
        }
    }
}