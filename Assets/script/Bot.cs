using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public float ySpeed = 3f;
    private float yPosition = 0;
    //public GameObject ball;
    public string WestOrEast;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WestOrEast == "West")
        {
            yPosition = yPosition + ySpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
            if (yPosition >= 5.4f)
            {
                ySpeed = ySpeed * -1f;
            }
            else if (yPosition <= -5.4f)
            {
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
        
        
        if (collision.gameObject.CompareTag("VWall"))
        {
            ySpeed = ySpeed * -1f;


        }
    }
}