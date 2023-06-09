using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove4 : MonoBehaviour
{
    Vector3 pos;
    float delta = 5.0f;
    float speed = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
