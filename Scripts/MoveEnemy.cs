using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{
    //public GameObject player;
    public float moveSpeed=1000f;
    public float followDistance = 10f;
    NavMeshAgent agent;
    Transform target;
    public Rigidbody rg;

    private void Start()
    {
        //  agent = GetComponent<NavMeshAgent>();
        // target = player.transform;
         //rg = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        /*
        float distance = Vector3.Distance(target.position, transform.position);

        if(distance<=followDistance)
        {
            agent.SetDestination(target.position);
        }
         
       

        //enemy.velocity = transform.forward * moveSpeed;

        */

        rg.AddForce(0f, 0f, 1f * moveSpeed*Time.deltaTime);
    }
}
