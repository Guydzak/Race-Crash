using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   

    public void onclickplay()
    {
        SceneManager.LoadScene("ColourSelection");
    }
    public void onclickexit()
    {
        Application.Quit();
    }
}
