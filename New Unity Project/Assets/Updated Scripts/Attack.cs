using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public bool touch1 = false;
    public bool touch2 = false;
    public AccelerationP1 p1;
    public AccelerationP2 p2;
    public int attackTime, boostTime;

    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<AccelerationP1>();
        p2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<AccelerationP2>();
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Collider1")
        {
            StartCoroutine(attack());
        }
        else if (player.gameObject.tag == "Collider2")
        {
            StartCoroutine(attack());
        }
    }

    public void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.tag == "Collider1")
        {
            touch1 = false;
        }
        else if (player.gameObject.tag == "Collider2")
        {
            touch2 = false;
        }
    }


    IEnumerator attack()
    {
        yield return new WaitForSeconds(attackTime);
        if (touch1 == true)
        {
            yield return new WaitForSeconds(boostTime);
            p1.lives -= 1;
            p1.speed = 180;
        }
        else if (touch2 == true)
        {
            yield return new WaitForSeconds(boostTime);
            p2.lives -= 1;
            p2.speed = 180;
        }
    }
}
