using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Material matSelect;
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
        GameObject.FindGameObjectWithTag("MaterialManager").GetComponent<MaterialManager>().player1Mat = matSelect;
        GameObject.FindGameObjectWithTag("Chasis").GetComponent<MaterialController>().UpdateColour();
    }
}
