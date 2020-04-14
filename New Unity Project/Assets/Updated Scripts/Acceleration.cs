using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    Rigidbody2D rb;
    float rotation;
    float x;
    float y;
    public float speed = 1;
    public float turnspeed = 1;
    int temp = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rotation = rb.rotation;
        rb.rotation = rotation - Input.GetAxis("Horizontal2") * turnspeed * Time.deltaTime * 10;
        rotation = Mathf.Deg2Rad * rotation;
        x = Mathf.Sin(rotation) * speed * Time.deltaTime * 10;
        y = Mathf.Cos(rotation) * speed * Time.deltaTime * 10;

        rb.velocity = new Vector2(-x, y);

        if(Input.GetKey(KeyCode.S))
        {
            speed = 30;
        }
        else if(Input.GetKey(KeyCode.W))
        {
            speed = 100;
        }
    }
}

