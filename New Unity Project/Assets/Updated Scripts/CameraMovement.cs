using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    Camera myCam;
    public float speed;
    float s;


    void Start()
    {
        myCam = GetComponent<Camera>();
        GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialManager>().SetColour();
    }


    void Update()
    {

        
        s = speed * Time.deltaTime;
        if(target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, speed) + new Vector3(0,0,-10);
        }
    }
}
