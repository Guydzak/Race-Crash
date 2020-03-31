using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2Sound : MonoBehaviour
{
    private AudioSource source;
    public AudioClip crash;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player2")
        {
            source.PlayOneShot(crash, 0.5f);
        }
    }
}
