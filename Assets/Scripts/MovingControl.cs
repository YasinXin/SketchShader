using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingControl : MonoBehaviour
{
    public float speed = 100;
    public float speed2 = 0;
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * speed, 0,Space.World);
        transform.Translate(Vector3.forward * speed2* Time.time);
    }
}
