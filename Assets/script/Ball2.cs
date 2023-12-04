using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;



public class ball2 : MonoBehaviour
{
    /// <summary>
    /// settings for ball in 0 player mode
    /// it should move in 2D and change course when it collides with a wall or paddle
    /// when ball hits left or right wall it scores
    /// if collides with paddle increase speed
    /// </summary>

    //variables
    // floats are X/Y positions
    public float Xposition = 0f;
    public float Yposition = 0f;
    // these increase the speed of the ball
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    //text object has to be linked in unity
    public TMP_Text scoreField;
    //these refer to the score of the right and left paddle
    private int leftScore = 0;
    private int rightScore = 0;
    //the score when it stops and shows the winner
    public int topScore = 10;
    private void resetBall(string leftOrRight)
    {
        Xposition = 0f;
        Yposition = 0f;
        scoreField.text = leftScore.ToString() + " - " + rightScore.ToString();
        if (leftOrRight == "left")
        {
            xSpeed = 7f;
            ySpeed = 7f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = -7f;
            ySpeed = 7f;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 7f;
        ySpeed = 7f;
        transform.position = new Vector3(Xposition, Yposition, 0);


    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
        if (leftScore >= topScore)
        {
            scoreField.text = "Left Player has won!";
            xSpeed = 0;
            ySpeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }
        else if (rightScore >= topScore)
        {
            scoreField.text = "Right Player has won!";
            xSpeed = 0;
            ySpeed = 0;
            Xposition = 0f;
            Yposition = 0f;
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
            xSpeed = xSpeed * -1.2f;
        }

    }

}
