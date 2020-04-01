using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer : MonoBehaviour
{

    public float speed = 1f; //Speed can be changed from the inspector.
    public Rigidbody2D G;
    public float min, max;

    public AudioClip drivingPlayer1;
    private AudioSource source1;


    void Start()
    {
        G = GameObject.FindGameObjectWithTag("Player1").GetComponent<Rigidbody2D>();
        source1 = GetComponent<AudioSource>();
        source1.PlayOneShot(drivingPlayer1, 2f);
    }
    // Update is called once per frame
    void Update()
    {
        G.velocity = new Vector2(G.velocity.x, Mathf.Clamp(G.velocity.y, min, max));
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.Translate(moveAmount);
    }
   
}
