using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import UI
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text time_counter;
    public float time_limit;
    public float current_time;
    // Start is called before the first frame update
    void Start()
    {
        current_time = time_limit;
    }

    // Update is called once per frame
    void Update()
    {
        current_time -= Time.deltaTime;
        if (current_time <= 10)
        {
            time_counter.color = Color.red;
        }
        if (current_time <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        time_counter.text = string.Format("{0:00}:{1:00}", Mathf.FloorToInt(current_time), Mathf.FloorToInt((current_time * 100) % 100));
    }
}
