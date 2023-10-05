using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed = 0f;
    public float ySpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.1f;
        ySpeed = 0.1f;
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
            xSpeed = xSpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("VWall"))
        {
            ySpeed = ySpeed * -1f;
        }
    }
}
