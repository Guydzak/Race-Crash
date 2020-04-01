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

    private AudioSource source;
    public AudioClip bush;
    public AudioClip playerOneBush;
    public AudioClip almostThere;


    // Start is called before the first frame update
    void Start()
    {
        P1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Rigidbody2D>();
        P2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Rigidbody2D>();
        p1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Racer>();
        p2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Racer2>();
        m = GameObject.FindGameObjectWithTag("Monster").GetComponent<Monster2>();
        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        hit = true;
        if (col.gameObject.tag == "Player1") // AND Player1 y ix greater than player2 y
        {
            source.PlayOneShot(playerOneBush, 1f);
            source.PlayOneShot(almostThere, 1f);
            Debug.Log("Closing in");
            p1.min = -5f;
            p1.max = -5f;
            if (m.dP2 > m.dP1)
            {
                m.touch = true;
                m.transform.position = new Vector3(m.transform.position.x, P1.transform.position.y + 7f, P1.transform.position.z);
                m.source.PlayOneShot(m.Roar, 0.2f);
            }
            
        }
        else if (col.gameObject.tag == "Player2")
        {
            source.PlayOneShot(bush, 0.3f);
            Debug.Log("Closing in");
            p2.min = -5f;
            p2.max = -5f;
            if (m.dP1 > m.dP2)
            {
                m.touch = true;
                m.transform.position = new Vector3(m.transform.position.x, P2.transform.position.y + 7f, P2.transform.position.z);
                m.source.PlayOneShot(m.Roar, 0.2f);
            }
           
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
