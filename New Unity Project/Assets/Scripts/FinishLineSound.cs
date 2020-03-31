using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineSound : MonoBehaviour
{
    private AudioSource source;
    public AudioClip P2;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
        checkwinner();
    }

    // Update is called once per frame
    

    void checkwinner()
    {
        if (PlayerPrefs.GetInt("f") == 2)
        {
            source.PlayOneShot(P2, 1f);
        }
    }
}
