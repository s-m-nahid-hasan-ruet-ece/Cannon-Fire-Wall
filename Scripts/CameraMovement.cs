using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    private float minY = 10000f;
    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x+ offset.x, player.position.y + offset.y, player.position.z+offset.z);
    }
}
