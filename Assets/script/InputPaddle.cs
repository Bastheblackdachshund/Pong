using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPaddle : MonoBehaviour
{
    public float speed = 3f;
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
    }
}

