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

    void Awake()
    {
        PlayerPrefs.SetInt("P1", 0);
        PlayerPrefs.SetInt("P2", 0);
    }
    void Start()
    {
        A = GameObject.FindGameObjectWithTag("Collision1").GetComponentInParent<AccelerationP1>();
        B = GameObject.FindGameObjectWithTag("Collision2").GetComponentInParent<AccelerationP2>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Collision1")
        {
            PlayerPrefs.SetInt("P1", 1);
            GetComponent<MeshRenderer>().enabled = false;
            picked = true;
            Debug.Log("player 1 Picked up");
            A.speed = 150;
            StartCoroutine(pickup());
            
        }
        else if(col.gameObject.tag == "Collision2")
        {
            PlayerPrefs.SetInt("P2", 1);
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
            PlayerPrefs.SetInt("P1", 0);
            A.speed = 100;
            picked = false;
            Debug.Log(" player 1 speed down");
            Destroy(gameObject);
        }
        else if(pickedB == true)
        {
            yield return new WaitForSeconds(timeForPickup);
            PlayerPrefs.SetInt("P2", 0);
            B.speed = 100;
            picked = false;
            Debug.Log("player 2 speed down");
            Destroy(gameObject);
        }
    }
}
