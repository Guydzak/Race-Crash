using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI2 : MonoBehaviour
{

    public Text finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("f") == 1)
        {
            finish.text = "Player 1 wins";
        }
        else if (PlayerPrefs.GetInt("f") == 2)
        {
            finish.text = "Player 2 Wins";
        }
    }
}
