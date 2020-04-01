using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2 : MonoBehaviour
{
    GameObject player1;
    GameObject player2;
    GameObject monster;

    public float dP1, dP2;
    public Obstacles O;
    public bool touch = false;
    public int T;

    public AudioSource source;
    public AudioClip Roar;
    public AudioClip closeOne;




    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        monster = GameObject.FindGameObjectWithTag("Monster");
        //O = GameObject.FindGameObjectWithTag("Obstacle").GetComponent<Obstacles>();
        
    }

    // Update is called once per frame
    void Update()
    {
        dP1 = Vector2.Distance(player1.transform.position, monster.transform.position);
        dP2 = Vector2.Distance(player2.transform.position, monster.transform.position);
        if (monster.transform.position.y > player1.transform.position.y && monster.transform.position.y > player2.transform.position.y)
        {
            if (dP1 > dP2 && touch == false)
            {

                monster.transform.position = new Vector3(monster.transform.position.x, player2.transform.position.y + 10f, player2.transform.position.z);
                
            }
            


                if (dP2 > dP1 && touch == false)
            {
                monster.transform.position = new Vector3(monster.transform.position.x, player1.transform.position.y + 10f, player1.transform.position.z);
            }
            


        }
    }

    



}
