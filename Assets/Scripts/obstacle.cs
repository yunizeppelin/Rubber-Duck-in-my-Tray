using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Vector3 init_position;
    public int distance = 5;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-5, 7), transform.position.y, Random.Range(-7, 5));
        init_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Moving obstacle up and down within a distance
        float update_y = init_position.y + Mathf.Sin(Time.time * 1) * distance;
        transform.position = new Vector3(init_position.x, update_y, init_position.z);
    }
}
