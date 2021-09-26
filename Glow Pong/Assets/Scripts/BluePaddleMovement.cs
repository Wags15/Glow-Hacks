using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePaddleMovement : MonoBehaviour
{

    Vector3 paddleWorldPosition;
    Vector2 lastWorldPosition;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    public float speed = 10.0f;
    public float boundY = 3.65f;

    public float boundX = -8.0f;

    private Rigidbody2D rb2d;

    public bool keyBoardMode = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (keyBoardMode)
        {
            var vel = rb2d.velocity;
            if (Input.GetKey(moveUp))
            {
                vel.y = speed;
            }
            else if (Input.GetKey(moveDown))
            {
                vel.y = -speed;
            }
            else
            {
                vel.y = 0;
            }
            if (Input.GetKey(moveLeft))
            {
                vel.x = -speed;
            }
            else if (Input.GetKey(moveRight))
            {
                vel.x = speed;
            }
            else
            {
                vel.x = 0;
            }
            rb2d.velocity = vel;

            var pos = transform.position;
            if (pos.y > boundY)
            {
                pos.y = boundY;
            }
            else if (pos.y < -boundY)
            {
                pos.y = -boundY;
            }
            if (pos.x < boundX)
            {
                pos.x = boundX;
            }
            else if (pos.x > 0.2)
            {
                pos.x = -0.2f;
            }
            transform.position = pos;
        }
        if (!keyBoardMode)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            paddleWorldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            if (paddleWorldPosition.y >= 3.6f)
            {
                paddleWorldPosition.y = 3.6f;
            }
            this.transform.position = new Vector3(paddleWorldPosition.x, paddleWorldPosition.y, 0);
        }


    }

    void FixedUpdate()
    {
        if (!keyBoardMode)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            paddleWorldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            if (paddleWorldPosition.y >= 3.6f)
            {
                paddleWorldPosition.y = 3.6f;
            }
            this.transform.position = new Vector3(paddleWorldPosition.x, paddleWorldPosition.y, 0);
            rb2d.velocity = new Vector2((paddleWorldPosition.x - lastWorldPosition.x) / (Time.deltaTime * 2), (paddleWorldPosition.y - lastWorldPosition.y) / (Time.deltaTime * 2));
            lastWorldPosition = new Vector2(paddleWorldPosition.x, paddleWorldPosition.y);
        }
    }



}
