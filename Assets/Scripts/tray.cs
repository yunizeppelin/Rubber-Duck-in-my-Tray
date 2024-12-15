using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x_axis = 0f;
        float y_axis = 0f;
        float z_axis = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            x_axis = -1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            x_axis = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            y_axis = 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            y_axis = -1f;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            z_axis = -1f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            z_axis = 1f;
        }
        GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(new Vector3(x_axis * 100, y_axis * 100, z_axis * 100) * Time.fixedDeltaTime));
    }
}
