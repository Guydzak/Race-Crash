using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public Material matSelect;
    public bool P2Selection = false;
    public GameObject readyButton;
    public GameObject raceButton;
    public GameObject p1Text;
    public GameObject p2Text;
    GameObject[] colours;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ApplyColour()
    {
        print("applying new colour");
        if (P2Selection == false)
        {
            GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialManager>().player1Mat = matSelect;
        }
        if(P2Selection == true)
        {
            GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialManager>().player2Mat = matSelect;
        }
        GameObject.FindGameObjectWithTag("Chasis").GetComponent<MaterialController>().UpdateColour();
    }
    public void P1Ready()
    {
        //change p2 colour instead
        colours = GameObject.FindGameObjectsWithTag("Button");
        foreach (GameObject colour in colours)
        {
            colour.GetComponent<ButtonScript>().P2Selection = true;
        }
        //hide disable ready button
        readyButton.SetActive(false);
        p1Text.SetActive(false);
        //enable race button
        raceButton.SetActive(true);
        //display p2 colour text
        p2Text.SetActive(true);
        //set P2 colour to current colour
        GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialManager>().player2Mat = GameObject.FindGameObjectWithTag("Chasis").GetComponent<MaterialController>().myColour;
    }
    public void Race()
    {
        
        SceneManager.LoadScene("Track Selector");
    }

    public void track1Sel()
    {
        SceneManager.LoadScene("Track_01");
    }
    public void track2Sel()
    {
        SceneManager.LoadScene("Track_02");
    }
    public void track3Sel()
    {
        SceneManager.LoadScene("Track_03");
    }
}
