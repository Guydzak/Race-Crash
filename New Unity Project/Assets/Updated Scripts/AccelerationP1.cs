﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AccelerationP1 : MonoBehaviour
{
    Rigidbody2D rb;
    float rotation;
    float x;
    float y;
    public float speed;
    public float turnspeed = 1;
    public float defSpeed;
    public int StartTime;
    public int pickupTime;
    int temp = 0;
    public bool firstTime = false;
    public UpdatedMonster2 m;
    public int lives;
    public Attack A;


    // Start is called before the first frame update


  
    
    void Start()
    {
        
        m = GameObject.FindGameObjectWithTag("Monster").GetComponent<UpdatedMonster2>();
        A = GameObject.FindGameObjectWithTag("Monster").GetComponentInChildren<Attack>();
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll; // avoids the rigidbody2(Car to fall when idle)
        StartCoroutine(Move()); //holds the car for the starting point and then starts to accelerate
    }

    // Update is called once per frame
    void Update()
    {
        
        if (firstTime == true)
        {
            rotation = rb.rotation;
            rb.rotation = rotation - Input.GetAxis("Horizontal2") * turnspeed * Time.deltaTime * 10;
            rotation = Mathf.Deg2Rad * rotation;
            x = Mathf.Sin(rotation) * speed * Time.deltaTime * 10;
            y = Mathf.Cos(rotation) * speed * Time.deltaTime * 10;

            rb.velocity = new Vector2(-x, y);

            if (Input.GetKey(KeyCode.S))
            {
                speed = 30;
            }
            else if (PlayerPrefs.GetInt("P1") == 1)
            {
                speed = 150;
            }
            else if (PlayerPrefs.GetInt("P1") == 0 && m.t1 == false && A.touch1 == false)
            {
                speed = 100;
            }


        }
    }

    IEnumerator Move()
    {
        
        yield return new WaitForSeconds(StartTime);
        rotation = rb.rotation;
        rb.rotation = rotation - Input.GetAxis("Horizontal2") * turnspeed * Time.deltaTime * 10;
        rotation = Mathf.Deg2Rad * rotation;
        x = Mathf.Sin(rotation) * speed * Time.deltaTime * 10;
        y = Mathf.Cos(rotation) * speed * Time.deltaTime * 10;

        rb.velocity = new Vector2(-x, y);

        if (Input.GetKey(KeyCode.S))
        {
            speed = 30;
        }
        else if (PlayerPrefs.GetInt("P1") == 1)
        {
            speed = 150;
        }
        else if (PlayerPrefs.GetInt("P1") == 0 && m.t1 == false && A.touch1 == false)
        {
            speed = 100;
        }

        firstTime = true; // in order to start the update function after the starting timer.
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;//Alllows movement for the rigid body2d(Car)
    }

   

}

