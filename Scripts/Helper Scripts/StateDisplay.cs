using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StateDisplay : MonoBehaviour
{
    public GameObject Topic;
    public GameObject text;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisplayState", 3f);
        Invoke("Display1Off", 6f);
        Invoke("Display2Off", 12f);
        Invoke("Display3Off", 18f);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayState()
    {
        Topic.SetActive(false);
        text.SetActive(true);
    }
    void Display1Off()
    {
        text.SetActive(false);
        text2.SetActive(true);
    }

    void Display2Off()
    {
        text2.SetActive(false);
        text3.SetActive(true);
    }

    void Display3Off()
    {
        text3.SetActive(false);
        text4.SetActive(true);
    }

}
