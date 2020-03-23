using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    GameObject player1;
    GameObject player2;
    GameObject monster;

    public float dP1, dP2;
    
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        monster = GameObject.FindGameObjectWithTag("Monster");
    }

    // Update is called once per frame
    void Update()
    {
        dP1 = Vector2.Distance(player1.transform.position, player2.transform.position);
        dP2 = Vector2.Distance(player2.transform.position, player2.transform.position);
        if(dP1 > dP2)
        {
            monster.transform.position = transform.position + new Vector3(transform.position.x, transform.position.y + 30f, transform.position.z);
        }
        if (dP2 > dP1)
        {
            monster.transform.position = transform.position + new Vector3(transform.position.x, transform.position.y + 30f, transform.position.z);
        }
    }
}
