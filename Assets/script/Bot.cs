using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    /// <summary>
    /// settings for the Botpaddle for 0 and 1 player mode
    /// it should change course when it hits the top wall
    /// </summary>
    //variables
    //increases oaddke speed
    public float ySpeed = 3f;
    //changes y position
    private float yPosition = 0;
    //asks wich side its on
    public string WestOrEast;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        //checks if it is the west or east paddle
        if (WestOrEast == "West")
        {
            yPosition = yPosition + ySpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
            //checks if y position is over 5.4f and -5.4f
            if (yPosition >= 3.6f)
            {
                //flips it if above 5.4f
                ySpeed = ySpeed * -1f;
            }
            else if (yPosition <= -3.6f)
            {
                // flips it if below -5.4f
                ySpeed = ySpeed * -1f;
            }
        }

        else if (WestOrEast == "East")
        {
            yPosition = yPosition + ySpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
            if (yPosition >= 3.6f)
            {
                ySpeed = ySpeed * -1f;
            }
            else if (yPosition <= -3.6f)
            {
                ySpeed = ySpeed * -1f;
            }
        }
            //transform.position = new Vector3(transform.position.x, ball.transform.position.y/ ySpeed, transform.position.z);
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            //checks if collides with a object trigger with the tag Vwall
        if (collision.gameObject.CompareTag("VWall"))
        {
            ySpeed = ySpeed * -1f;


        }
    }
}