using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class ballScript : MonoBehaviour
{
    
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public TMP_Text scoreField;
    private int leftScore = 0;
    private int rightScore = 0;
    public int topScore = 10;
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
    // Start is called before the first frame update
    void Start()    
    {
        xSpeed = 0.05f;
        ySpeed = 0.05f;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed;
        Yposition += ySpeed;
        transform.position = new Vector3(Xposition, Yposition, 0);

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
