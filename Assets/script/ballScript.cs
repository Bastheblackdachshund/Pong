using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;



public class ballScript : MonoBehaviour
{
    /// <summary>
    /// settings for ball in 1 and 2 player mode
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

    //resets ball and adds one to the score for the side that scored
    private void resetBall(string leftOrRight)
    {
        //starting position for x/y
        Xposition = 0f;
        Yposition = 0f;
        //displays current score in textfield
        scoreField.text = leftScore.ToString() + " - " + rightScore.ToString();
        //checks on argument from the function if left or right is typed in
        if (leftOrRight == "left")
        {
            //ball goes right and up
            xSpeed = 3f;
            ySpeed = 3f;
        }
        else if (leftOrRight == "right")
        {
            //ball goes left and up
            xSpeed = -3f;
            ySpeed = 3f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 3f;
        ySpeed = 3f;
        //set starting x/y position for ball
        transform.position = new Vector3(Xposition, Yposition, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        //update the x/y positions of the ball using xspeed and yspeed
        // time.delaTime updates in real time so no player has an advantage
        Xposition += xSpeed*Time.deltaTime;
        Yposition += ySpeed*Time.deltaTime;
        //updates the position with the x and y position
        transform.position = new Vector3(Xposition, Yposition, 0);

        //checks if leftscore or rightscore is bigger or equel to the topscore
        //if one is larger it stops the ball and places it in the middle and shows in scorefield who won
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
    //if it hits something with collider2d and that one is said to a trigger it does something
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks wich tag a object has and does something based on that
        //if it sees the object has a trigger and Hwall tag it flips the y direction
        if (collision.gameObject.CompareTag("HWall"))
        {
            ySpeed = ySpeed * -1f;

        }
        //if it sees the object has a trigger and Left tag it adds 1 score to right and triggers reset function with left argument
        else if (collision.gameObject.CompareTag("Left"))
        {
            rightScore++;
            resetBall("left");
        }
        //if it sees the object has a trigger and Right tag it adds 1 score to left and triggers reset function with right argument
        else if (collision.gameObject.CompareTag("Right"))
        {
            leftScore++;
            resetBall("right");
        }
        //if it sees the object has a trigger and Player tag it flips the x direction and speeds up xSpeed by 10%
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f;
        }

    }
    
}
