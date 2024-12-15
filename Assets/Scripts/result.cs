using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import UI

public class result : MonoBehaviour
{
    public Text score_text;
    public GameObject data;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data"); 
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = string.Format("SCORE {0:0000}", data.GetComponent<data>().point);
    }
}
