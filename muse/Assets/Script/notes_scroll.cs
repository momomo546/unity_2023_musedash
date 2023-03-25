using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_scroll : MonoBehaviour
{
    public float speed = 1.0f;
    private GameObject parentObj;

    void Start()
    {
        parentObj = transform.parent.gameObject;
    }

    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * speed,0,0);
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy (parentObj);
    }
}
