using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;

    //function that handles movement and has variables for up and down keycode?
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y <= 3.6f)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y >= -3.6f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Change within Unity if it's left or the right paddle
        if (leftOrRight == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }
      
        
    }
}