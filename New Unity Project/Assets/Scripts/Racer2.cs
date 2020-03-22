using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer2 : MonoBehaviour
{

    public float speed = 1f; //Speed can be changed from the inspector.


    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal2"), 0, 0);
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.Translate(moveAmount);
    }
}
