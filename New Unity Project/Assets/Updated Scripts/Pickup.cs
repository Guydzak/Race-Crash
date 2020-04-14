using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public Acceleration A;
    public int T;
    public bool picked = false;
    
    void Start()
    {
        A = GameObject.FindGameObjectWithTag("Player1").GetComponentInParent<Acceleration>();
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
    }

    IEnumerator pickup()
    {
        yield return new WaitForSeconds(T);
        A.speed = 100;
        picked = false;
        Debug.Log("speed down");
        Destroy(gameObject);
    }
}
