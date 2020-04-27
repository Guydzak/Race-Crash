using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class Finish : MonoBehaviour
{
    public Text T;
    public int WinCountP1;
    public int WinCountP2;
   


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Win") == 1)
            T.text = "Player 1 Wins";
        if (PlayerPrefs.GetInt("Win") == 2)
            T.text = "Player 2 Wins";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        AnalyticsEvent.Custom("Race finished",new Dictionary<string, object>
        {
            {"winner", col.gameObject.tag},
            {"finish", Time.timeSinceLevelLoad},
            {"Player 1 Win Count", WinCountP1},
            {"Player 2 Win Count", WinCountP2}
        });
        if (col.gameObject.tag == "Player1")
        {
            PlayerPrefs.SetInt("Win", 1);
            WinCountP1 += 1;
            SceneManager.LoadScene("UpdatedFinish");
            
        }
        else if(col.gameObject.tag == "Player2")
        {
            PlayerPrefs.SetInt("Win", 2);
            WinCountP2 += 1;
            SceneManager.LoadScene("UpdatedFinish");
        }

        
     
    }
}
