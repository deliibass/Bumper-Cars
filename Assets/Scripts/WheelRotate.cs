using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    public float speed = 5.0f;
    private float rot = 0.0f;
    void Update()
    {
        rot -= Input.GetAxis("Horizontal") * speed;
        transform.eulerAngles = new Vector3(0.0f, 0.0f, rot);
    }
}
