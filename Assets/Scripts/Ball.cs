using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    public Vector2 startingVelocity = new Vector2(15, -20);
    private Vector3 startingPosition;
    public GameObject Game_Over;
    public GameObject youwinsign;
    UnityEngine.UI.Text livesValue;
    public Text pointsValue;

    int lives = 3;
    int points = 0;

    void Start()
    {
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        livesValue.text = lives.ToString();
    }


    void Update()
    {
        if (transform.position.y < -5.5f)
        {
            GetOut();
        }
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = startingVelocity;
        }
    }

    void GetOut()
    {
        Debug.Log("You are out");
        lives = lives - 1;
        //livesValue.text = lives.ToString();

        transform.position = startingPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector2();


        if (lives == 0)
        {
            DoGameOver();
        }
    }

    void DoGameOver()
    {
        Game_Over.SetActive(true);
    }
    public void Brick_break()
    {
        var bricks_left = FindObjectsOfType<Brick>().Length;
        points += 1;
        //pointsValue.text = points.ToString();
        if (bricks_left == 0)
        {
            youwinsign.SetActive(true);
        }
    }
}