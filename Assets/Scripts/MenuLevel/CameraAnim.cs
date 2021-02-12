using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnim : MonoBehaviour
{
    //adjust this to change speed
    [SerializeField]
    float speed = 3;
    //adjust this to change how high it goes
    [SerializeField]
    float width = 6f;

    Vector3 pos;

    int chooseDirection;

    private void Start()
    {
        pos = transform.position;
    }
    void FixedUpdate()
    {

        //calculate what the new X position will be
        float newX = Mathf.Sin(Time.time * speed) * width + pos.x;
        //set the object's X to the new calculated X
        transform.position = new Vector3(newX * 2, transform.position.y, transform.position.z);

    }
}
