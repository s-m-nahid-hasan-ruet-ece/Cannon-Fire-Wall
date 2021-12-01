using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckOnCollision : MonoBehaviour
{
    public GameObject wreckedVersion;
    public GameObject wall;
    public bool flag=false;
    public FireProjectile fireProjectile;

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "projectile")
        {
            Destroy(gameObject);
            Instantiate(wreckedVersion, transform.position, transform.rotation);
        }
        else if(collision.collider.tag=="wall")
        {
            Destroy(wall);
            fireProjectile.flag = true;
        }
    }
}
