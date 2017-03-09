using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strong_brick : MonoBehaviour {
    int hit=3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        hit-=1;
        if (hit == 0)
        {
            gameObject.SetActive(false);
        }
    }
}