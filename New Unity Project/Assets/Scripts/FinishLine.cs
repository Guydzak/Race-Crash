using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public PlayerPrefs f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            PlayerPrefs.SetInt("f", 1);
            SceneManager.LoadScene("Finish");
        }
        else if(collision.gameObject.tag == "Player2")
        {
            PlayerPrefs.SetInt("f", 2);
            SceneManager.LoadScene("Finish");
        }
    }

}
