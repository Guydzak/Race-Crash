using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatedMonster : MonoBehaviour
{
    
    public Transform target;
    public float stoppingDistance;
    public float speed;
    

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player1").GetComponent<Transform>();
       
    }
    void Update()
    {
        
        if (Vector2.Distance(transform.position,target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

}
