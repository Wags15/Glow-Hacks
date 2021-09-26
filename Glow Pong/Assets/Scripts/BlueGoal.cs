using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGoal : MonoBehaviour
{
    public ScoreCounter Score;
    public Ball ball;


    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.collider.CompareTag("Ball"))
        {
            ball.ResetBall();
            Score.RedScore++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}