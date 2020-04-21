using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public AccelerationP1 A;
    public AccelerationP2 B;
    public int timeForPickup;
    public bool picked = false , pickedB = false;
    
    void Start()
    {
        A = GameObject.FindGameObjectWithTag("Player1").GetComponent<AccelerationP1>();// we are accessing the parent of this collider
        B = GameObject.FindGameObjectWithTag("Player2").GetComponent<AccelerationP2>();
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
            Debug.Log("player 1 Picked up");
            A.speed = 150;
            StartCoroutine(pickup());
            
        }
        else if(col.gameObject.tag == "Player2")
        {
            GetComponent<MeshRenderer>().enabled = false;
            pickedB = true;
            Debug.Log("player 2 Picked up");
            B.speed = 150;
            StartCoroutine(pickup());

        }
    }

    IEnumerator pickup()
    {

        if (picked == true)
        {
            yield return new WaitForSeconds(timeForPickup);
            A.speed = 100;
            picked = false;
            Debug.Log(" player 1 speed down");
            Destroy(gameObject);
        }
        else if(pickedB == true)
        {
            yield return new WaitForSeconds(timeForPickup);
            B.speed = 100;
            picked = false;
            Debug.Log("player 2 speed down");
            Destroy(gameObject);
        }
    }
}
