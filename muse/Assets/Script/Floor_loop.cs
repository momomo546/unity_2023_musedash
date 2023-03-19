using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_loop : MonoBehaviour
{
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * speed,0,0);

        if(transform.position.x <= -29.98f)
        {
            transform.position = new Vector3(30f,0,0);
        }
    }
}
