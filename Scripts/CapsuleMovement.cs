using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public Rigidbody player;
    public float force;
    public float jumpForce;

    [HideInInspector]
    public bool f = false;

    /*
     * Additional feature I've added to jump by pressing space key
     */

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="ground")
        {
            Debug.Log("ground is touched");
            f = true;
        }

    }

    void FixedUpdate()
    {
        if (Input.GetKey("j"))
        {
            player.AddForce(0f, 0f, -1f*force * Time.deltaTime);
        }
        else if (Input.GetKey("l"))
        {
            player.AddForce(0f, 0f, 1f * force * Time.deltaTime);
        }
        else if (Input.GetKey("i"))
        {
            player.AddForce(-1*force * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey("k"))
        {
            player.AddForce(1f*force * Time.deltaTime, 0f, 0f);
        }

        /*
        if (Input.GetKey("space") && f==true)
        {
            Debug.Log("space key is pressed");
            f = false;
            player.AddForce(0f, 1f * jumpForce, 0f);
        }
        */
    }
}
