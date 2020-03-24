using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1 : MonoBehaviour
{
    public Rigidbody2D G;
    // Start is called before the first frame update
    void Start()
    {
        G = GameObject.FindGameObjectWithTag("Player1").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        G.velocity = new Vector2(G.velocity.x, Mathf.Clamp(G.velocity.y, -10f, -20f));
    }
}
