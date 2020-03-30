using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    protected Rigidbody2D rb2d;
    Rigidbody2D P1, P2;
    public bool hit = false;
    public Racer p1;
    public Racer2 p2;
    Monster2 m;


    // Start is called before the first frame update
    void Start()
    {
        P1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Rigidbody2D>();
        P2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Rigidbody2D>();
        p1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Racer>();
        p2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Racer2>();
        m = GameObject.FindGameObjectWithTag("Monster").GetComponent<Monster2>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        hit = true;
        if (col.gameObject.tag == "Player1")
        {
            Debug.Log("Closing in");
            m.touch = true;
            m.transform.position = new Vector3(m.transform.position.x, P1.transform.position.y + 7f , P1.transform.position.z);
            p1.min = -5f;
            p1.max = -5f;
        }
        else if (col.gameObject.tag == "Player2")
        {
            Debug.Log("Closing in");
            m.touch = true;
            m.transform.position = new Vector3(m.transform.position.x, P2.transform.position.y + 7f, P2.transform.position.z);
            p2.min = -5f;
            p2.max = -5f;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        hit = false;
        if (col.gameObject.tag == "Player1")
        {
            m.touch = false;
            p1.min = -10f;
            p1.max = -20f;
        }
        else if (col.gameObject.tag == "Player2")
        {
            m.touch = false;
            p2.min = -10f;
            p2.max = -20f;
        }
    }
}
