using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball2 : MonoBehaviour
{
    public Text text;
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
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HWall"))
        {
            transform.position = new Vector3(Xposition, Yposition, 0);

        }
        else if (collision.gameObject.CompareTag("VWall"))
        {
            ySpeed = ySpeed * 0f;


        }
    }
}
