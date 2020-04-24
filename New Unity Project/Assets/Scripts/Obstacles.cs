using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    protected Rigidbody2D rb2d;
    Rigidbody2D P1, P2;
    public bool hit = false;
    public AccelerationP1 p1;
    public AccelerationP2 p2;
    public UpdatedMonster2 m;

    private AudioSource source;
    public AudioClip bush;
    public AudioClip playerOneBush;
    public AudioClip almostThere;
    public AudioClip closeOne;
    public float slowAmount;


    // Start is called before the first frame update
    void Start()
    {
        P1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Rigidbody2D>();
        P2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Rigidbody2D>();
        p1 = GameObject.FindGameObjectWithTag("Collision1").GetComponentInParent<AccelerationP1>();
        p2 = GameObject.FindGameObjectWithTag("Collision2").GetComponentInParent<AccelerationP2>();
        m = GameObject.FindGameObjectWithTag("Monster").GetComponent<UpdatedMonster2>();
        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        hit = true;
        if (col.gameObject.tag == "Collision1") // AND Player1 y ix greater than player2 y
        {
            //source.PlayOneShot(playerOneBush, 1f);
            //source.PlayOneShot(almostThere, 1f);
            Debug.Log("Closing in");
            p1.speed = slowAmount;
            if (m.dp2 > m.dp1)
            {
                m.touch = true;
                m.moveSpeed = m.chaseSpeed;
                //m.transform.position = new Vector3(m.transform.position.x, P1.transform.position.y + 7f, P1.transform.position.z);
                //m.source.PlayOneShot(m.Roar, 0.2f);
                //m.source.PlayOneShot(m.closeOne, 1f);
            }
            
        }
        else if (col.gameObject.tag == "Collision2")
        {
            //source.PlayOneShot(almostThere, 1f);
            //source.PlayOneShot(bush, 0.3f);
            Debug.Log("Closing in");
            p2.speed = slowAmount;
            if (m.dp1 > m.dp2)
            {
                m.touch = true;
                m.moveSpeed = m.chaseSpeed;
                //m.transform.position = new Vector3(m.transform.position.x, P2.transform.position.y + 7f, P2.transform.position.z);
                //m.source.PlayOneShot(m.Roar, 0.2f);
                // m.source.PlayOneShot(m.friendly, 01f);

            }
           
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        hit = false;
        if (col.gameObject.tag == "Collision1")
        {
            m.touch = false;
            m.moveSpeed = m.defSpeed;
            p1.speed = p1.defSpeed;
        }
        else if (col.gameObject.tag == "Collision2")
        {
            m.touch = false;
            m.moveSpeed = m.defSpeed;
            p2.speed = p2.defSpeed; ;
        }
    }
}
