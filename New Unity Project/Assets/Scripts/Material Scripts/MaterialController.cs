using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public Material myColour;
    // Start is called before the first frame update
    void Start()
    {
        myColour = GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialManager>().player1Mat;
        gameObject.GetComponent<Renderer>().material = myColour;
    }

    public void UpdateColour()
    {
        print("changed the colour");
        myColour = GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialManager>().player1Mat;
        gameObject.GetComponent<Renderer>().material = myColour;
    }
}
