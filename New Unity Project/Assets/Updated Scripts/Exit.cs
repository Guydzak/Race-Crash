﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ex()
    {
        Application.Quit();
    }
    public void playAgain()
    {
        SceneManager.LoadScene("ColourSelection");
    }
}
