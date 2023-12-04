using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;

    /// <summary>
    /// function that handles movement and has variables for up and down keycode
    /// </summary>
    /// <param name="up"> asks wich imput is up
    /// <param name="down"> asks wich imput is down
    
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        //when you press and hold up key the paddle moves up until it reaches 3.6f
        if (Input.GetKey(up) && transform.position.y <= 3.6f)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        //when you press and hold down key the paddle moves down until it reaches 3.6f
        else if (Input.GetKey(down) && transform.position.y >= -3.6f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Change within Unity if it's left or the right paddle
        //and changes key binds based on that
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