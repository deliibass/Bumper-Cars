using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour 
{

    public Transform player;
    public float offsetY = 10;
    public float offsetZ = -10;


    void LateUpdate () {
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offsetY, player.transform.position.z + offsetZ);
        //this.transform.RotateAround(Vector3.right, player.position, 100 * Time.deltaTime);

	}

}
