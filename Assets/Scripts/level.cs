using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import UI

public class level : MonoBehaviour
{
    public Text level_text;
    public GameObject data;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
    }

    // Update is called once per frame
    void Update()
    {
        level_text.text = string.Format("LEVEL {0:0}", data.GetComponent<data>().level);
    }
}
