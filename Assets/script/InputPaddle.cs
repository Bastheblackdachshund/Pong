using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InputPaddle : MonoBehaviour
{
    public float speed = 3f;
    private float yPosition = 0;
    public string WestOrEast;
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        



        if (WestOrEast == "West")
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("Yes w is pressed");
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("Yes S is pressed");
            }
        }
        else if (WestOrEast == "East")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("Yes up is pressed");
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("Yes down is pressed");
            }
           
            
        }
        else if (WestOrEast == "Or")
        {
            if (yPosition >= 3.6f)
            {
                ySpeed = ySpeed * -1f;
            }
            else if (yPosition <= -3.6f)
            {
                ySpeed = ySpeed * -1f;
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("Yes w is pressed");
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("Yes S is pressed");
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                Debug.Log("Yes D is pressed");
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                Debug.Log("Yes A is pressed");
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HWall"))
        {
            Debug.Log("Yes");

        }
        else if (collision.gameObject.CompareTag("VWall"))
        {
            Debug.Log("Yes");


        }
    }
    



}
    


