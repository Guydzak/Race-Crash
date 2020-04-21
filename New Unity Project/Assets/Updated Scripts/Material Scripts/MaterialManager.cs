using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MaterialManager : MonoBehaviour
{
    public Material player1Mat;
    public Material player2Mat;

    public GameObject player1;
    public GameObject player2;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetColour()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
        if (scene.name == "ColourSelection")
        {
            player1 = null;
            player2 = null;
        }
        else
        {
            player1 = GameObject.FindGameObjectWithTag("Player1");
            player1.GetComponentInChildren<Renderer>().material = player1Mat;
            player2 = GameObject.FindGameObjectWithTag("Player2");
            player2.GetComponentInChildren<Renderer>().material = player2Mat;
        }
    }
}
