using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    // This script launches a projectile prefab by instantiating it at the position
    // of the GameObject on which it is placed, then then setting the velocity
    // in the forward direction of the same GameObject.

[SerializeField] private AudioClip sndNewDamage;
[SerializeField] private AudioClip sndCrashWarning;
[SerializeField] private AudioClip sndHasDamageWarning;
[SerializeField] private AudioClip sndFueldLow;
    public Rigidbody projectile;
    public float speed = 4;

    public GameObject wall;
    public GameObject robot;
    float time;
    public bool flag = false;
    int c = 0;

    private void Start()
    {
        time = Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="wall")
        {
            
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(Time.deltaTime +"  --  "+ time);
        if (flag == true && c>10)
        {
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
            time = Time.deltaTime;
            c = 0;
        }

        if(c<=10)
        {
            c++;
        }
        
        
    }
}
