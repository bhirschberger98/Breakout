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
        gameObject.SetActive(false);
        hit -= 1;
        if (hit == 0)
        {
            gameObject.SetActive(false);
        }
    }
}