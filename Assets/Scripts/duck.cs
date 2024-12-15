using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class duck : MonoBehaviour
{
    public GameObject score_text;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star5;
    public GameObject flag;
    public GameObject data;
    // Start is called before the first frame update
    void Start()
    {
        flag = GameObject.Find("flag"); 
        data = GameObject.Find("Data"); 
    }

    // Collision
    void OnTriggerEnter(Collider other)
    {
        // with stars
        if ((other.gameObject == star1) || (other.gameObject == star2) || (other.gameObject == star3) || (other.gameObject == star4) || (other.gameObject == star5))
        {
            score_text.GetComponent<score>().data.GetComponent<data>().point += 100;
            Destroy(other.gameObject);
        }
        // with flag
        if (other.gameObject == flag)
        {
            data.GetComponent<data>().level += 1;
            if (data.GetComponent<data>().level == 2)
            {
                SceneManager.LoadScene("Level2");
            } else if (data.GetComponent<data>().level == 3)
            {
                SceneManager.LoadScene("Victory");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if duck is falling out of bound
        if (transform.position.y <= -24)
        {
            // Teleport duck to the sky
            transform.position = new Vector3(0, 24, 0);
            // Reset rotation
            transform.rotation = Quaternion.Euler(0, 90, 0);
            // Reset velocity
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
