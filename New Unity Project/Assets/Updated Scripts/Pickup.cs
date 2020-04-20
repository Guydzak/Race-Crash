﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public AccelerationP1 A;
    public int timeForPickup;
    public bool picked = false;
    
    void Start()
    {
        A = GameObject.FindGameObjectWithTag("Player1").GetComponentInParent<AccelerationP1>();// we are accessing the parent of this collider 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player1")
        {
            GetComponent<MeshRenderer>().enabled = false;
            picked = true;
            Debug.Log("Picked up");
            A.speed = 150;
            StartCoroutine(pickup());
            
        }
        else if(col.gameObject.tag == "Player2")
        {
            GetComponent<MeshRenderer>().enabled = false;
            picked = true;
            Debug.Log("Picked up");
            A.speed = 150;
            StartCoroutine(pickup());

        }
    }

    IEnumerator pickup()
    {
        
        yield return new WaitForSeconds(timeForPickup);
        A.speed = 100;
        picked = false;
        Debug.Log("speed down");
        Destroy(gameObject);
    }
}
