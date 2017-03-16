using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_Brick : MonoBehaviour {
    public int hit;
	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        hit = hit - 1;
        transform.position.y = transform.position.y + 5;

        if (hit == 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().Brick_break();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
