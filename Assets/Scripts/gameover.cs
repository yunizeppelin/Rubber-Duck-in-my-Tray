using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject data;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data"); 
    }

    // Update is called once per frame
    void Update()
    {
        // Press R to restart
        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(data);
            SceneManager.LoadScene("StartScreen");
        }
        // Press ESC to quit the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
