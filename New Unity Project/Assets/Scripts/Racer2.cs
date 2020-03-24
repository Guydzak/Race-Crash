using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer2 : MonoBehaviour
{

    public float speed = 1f; //Speed can be changed from the inspector.
    public Rigidbody2D G;
    public float min, max;


    void Start()
    {
        G = GameObject.FindGameObjectWithTag("Player2").GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        G.velocity = new Vector2(G.velocity.x, Mathf.Clamp(G.velocity.y, min, max));
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal2"), 0, 0);
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.Translate(moveAmount);
    }
}
