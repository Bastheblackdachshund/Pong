using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Ball2 : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public TMP_Text scoreField;
    private int leftScore = 0;
    private int rightScore = 0;
    public int topScore = 10;

    //function that handles movement and has variables for up and down keycode?
    private void resetBall(string leftOrRight)
    {
        Xposition = 0f;
        Yposition = 0f;
        scoreField.text = leftScore + " - " + rightScore;
        if (leftOrRight == "left")
        {
            xSpeed = 3f;
            ySpeed = 3f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = -3f;
            ySpeed = 3f;
        }
    }
    void setKeyAndMovement(KeyCode up, KeyCode down, KeyCode right, KeyCode left)
    {
        if (Input.GetKey(up) && transform.position.y <= 4.4f)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y >= -4.4f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(right) && transform.position.x <= 8.6f)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(left) && transform.position.x >= -8.6f)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Change within Unity if it's left or the right paddle
       
        if (leftOrRight == "or")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S, KeyCode.D, KeyCode.A);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HWall"))
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("Left"))
        {
            rightScore++;
            resetBall("left");
        }
        else if (collision.gameObject.CompareTag("Right"))
        {
            leftScore++;
            resetBall("right");
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f;
        }

    }   
}